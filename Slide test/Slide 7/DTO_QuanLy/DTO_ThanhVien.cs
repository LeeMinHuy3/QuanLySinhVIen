using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLy
{
    public class DTO_ThanhVien
    {
        private int _ThanhVien_ID;
        private string _ThanhVien_Name;
        private string _ThanhVien_Phone;
        private string _ThanhVien_Email;

        public int ThanhVien_ID
        {
            get
            {
                return _ThanhVien_ID;
            }

            set
            {
                _ThanhVien_ID = value;
            }
        }

        public string ThanhVien_Name
        {
            get
            {
                return _ThanhVien_Name;
            }

            set
            {
                _ThanhVien_Name = value;
            }
        }

        public string ThanhVien_Phone
        {
            get
            {
                return _ThanhVien_Phone;
            }

            set
            {
                _ThanhVien_Phone = value;
            }
        }

        public string ThanhVien_Email
        {
            get
            {
                return _ThanhVien_Email;
            }

            set
            {
                _ThanhVien_Email = value;
            }
        }

        public DTO_ThanhVien()
        {

        }

        public DTO_ThanhVien(int id, string name, string phone, string email)
        {
            this.ThanhVien_ID = id;
            this.ThanhVien_Name = name;
            this.ThanhVien_Phone = phone;
            this.ThanhVien_Email = email;
        }
    }
}
