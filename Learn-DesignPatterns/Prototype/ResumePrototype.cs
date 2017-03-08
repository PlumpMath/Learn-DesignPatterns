using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    /// <summary>
    /// 简历原型
    /// </summary>
    class ResumePrototype : ICloneable
    {
        private string Name;

        private int Age;

        private string Sex;
        
        private string Introduce;

        private WorkExperience workExperience;

        public ResumePrototype(string _name)
        {
            this.Name = _name;
            workExperience = new WorkExperience();
        }

        private ResumePrototype(WorkExperience _workExperience)
        {
            _workExperience.Company="22";
            workExperience = (WorkExperience)_workExperience.Clone();
        }


        private WorkExperience fuzhi(WorkExperience _workExperience)
        {
            _workExperience.Company = "22";
            workExperience = (WorkExperience)_workExperience.Clone();
            workExperience.Company = "33";
            return workExperience;
        }

        public void SetPersonalInfo(int _age, string _sex, string _introduce)
        {
            this.Age = _age;
            this.Sex = _sex;
            this.Introduce = _introduce;
        }

        public void SetWorkExperience(string _company,string _workDate)
        {
            workExperience.Company = _company;
            workExperience.WorkDate = _workDate;
        }

        public void Display()
        {
            Console.WriteLine(string.Format("名字{0}，年龄{1}，性别{2}", this.Name, Age, Sex));
            Console.WriteLine(string.Format("在{0}在{1}工作", workExperience.WorkDate, workExperience.Company));
        }

        ///// <summary>
        ///// 浅复制需要
        ///// </summary>
        ///// <returns></returns>
        //public object Clone()
        //{
        //    return MemberwiseClone();
        //}
        
        /// <summary>
        /// 深复制需要
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {

            fuzhi(workExperience);

            ResumePrototype rp = new ResumePrototype(workExperience);
            rp.Age = Age;
            rp.Sex = Sex;
            rp.Introduce = Introduce;
            rp.Name = Name;
            return rp;
        }
    }
}
