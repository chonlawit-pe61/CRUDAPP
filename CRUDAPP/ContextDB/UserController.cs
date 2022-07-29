using CRUDAPP.ContextDB.EntityData;
using CRUDAPP.Models;
using DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDAPP.ContextDB
{
    public class UserController
    {
        CRUD_V1Entities db = new CRUD_V1Entities();
        public List<tblCURD> getData()
        {
            var Data = db.tblCURDs.ToList();
            return Data;
        }
        public string insert(UserEntity value)
        {
            try
            {
                value.insert();
                return "Insert Data Sucess";
            }catch(Exception ex)
            {
                return ex.Message;
            }
        }
        public string update(UserEntity user)
        {
            try
            {
                user.UpDateDbUser();
                return "Update Data Sucess";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string DelData(UserEntity user)
        {
            try
            {
                user.DelDataUser();
                return "Del Data Sucess";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
    }
}