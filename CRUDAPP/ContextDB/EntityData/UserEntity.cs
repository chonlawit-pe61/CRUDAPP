using CRUDAPP.Models;
using DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDAPP.ContextDB.EntityData
{
    public class UserEntity
    {
        CRUD_V1Entities db = new CRUD_V1Entities();

        public int id { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string address { get; set; }
        public void insert()
        {
            tblCURD tblCURD = new tblCURD();
            tblCURD.name = this.name;
            tblCURD.lastname = this.lastname;
            tblCURD.address = this.address;
            db.tblCURDs.Add(tblCURD);
            db.SaveChanges();

        }
        public void DelDataUser()
        {
            tblCURD tblCURD = new tblCURD();
            tblCURD.id = this.id;
            var dataUser = db.tblCURDs.Where(data => data.id == tblCURD.id).FirstOrDefault();
            if (dataUser != null) {
                db.tblCURDs.Remove(dataUser);
                db.SaveChanges();
            }
            
        }
        public void UpDateDbUser()
        {
            tblCURD tblCURD = new tblCURD();
            tblCURD.id = this.id;
            var dataUser = db.tblCURDs.Where(data => data.id == tblCURD.id).FirstOrDefault();
            if (dataUser != null)
            {
                dataUser.id = this.id;
                dataUser.name = this.name;
                dataUser.lastname = this.lastname;
                dataUser.address = this.address;
                db.SaveChanges();
            }
        }
    }
}