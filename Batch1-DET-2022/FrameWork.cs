using Batch1_DET_2022.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    class FrameWork
    {
        public static object Empno { get; private set; }

        static void Main(string[] args)
        {
            // GetAllEmpDetailes();
            // DeleteNewEmployee();

            //UpdateNewEmployee();

            //GetEmpDetailByID();
            //AddNewEmployee();
            // UpdateNewEmployee1();
            //storedprocedurewithout();
            // CallStoredProcwithSQLParamater_insert();
            //storedprocedureupdate();

            Console.ReadLine();

        }

        //private static void AddNewEmployee()
        //{
        //    var ctx = new traningtsqlContext();

        //    try
        //    {
        //        Emp employee = new Emp();
        //        employee.Empno = 2979;
        //        employee.Ename = "shilpa";
        //        employee.Sal = 1000;
        //        employee.Deptno = 30;
        //        employee.Job = "Trainer";
        //        ctx.Add(employee);
        //        ctx.SaveChanges();
        //        Console.WriteLine("New employee added");

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);

        //    }

        //private static void GetAllEmpDetailes()
        //{

        //    var ctx = new traningtsqlContext();
        //    var emps = ctx.Emps;

        //    foreach (var emp in emps)
        //    {
        //        Console.WriteLine(emp.Ename + "  "+ emp.Sal);
        //    }

        //}


        //private static void GetEmpDetailByID()
        //{
        //    var ctx = new traningtsqlContext();
        //    var emp = ctx.Emps.Where(e => e.Empno == 7499).SingleOrDefault();
        //    Console.WriteLine(emp.Ename + " " + emp.Sal + " " + emp.Job);
        //}


        //private static void UpdateNewEmployee()
        //{

        //    var ctx = new traningtsqlContext();

        //    try
        //    {
        //        Emp employee = new Emp();
        //        employee.Empno = 7499;
        //        employee.Ename = "sheela";
        //        employee.Sal = 100;
        //        employee.Deptno = 30;
        //        employee.Job = "Trainer";
        //        ctx.Update(employee);
        //        ctx.SaveChanges();
        //        Console.WriteLine("employee deleted");

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);

        //    }
        //}

        //private static void UpdateNewEmployee1()

        //{

        //    var ctx = new traningtsqlContext();
        //    var EMP = ctx.Emps.FromSqlRaw("GetAllEmpsDetailsbyEmpno @p0 ",7521).ToList();
        //    foreach (var e in EMP)
        //    {
        //        Console.WriteLine(e.Ename);

        //    }

        // }


        private static void storedprocedurewithout()

        {

            var ctx = new traningtsqlContext();
            var EMP = ctx.Emps.FromSqlRaw("GetEmployeeDetails2").ToList();
            foreach (var e in EMP)
            {
                Console.WriteLine(e.Ename);

            }

        }

        //private static void storedprocedureupdate()

        //{
        //    var ctx = new traningtsqlContext();
        //      try
        //{
        //   var id = 7654;
        //string newname = "richa";
        //int EMP = ctx.Database("updatenames @p0, @p1", Empno,newname: new[] { "7654", "Gase" });

        //}

        //public static void stroedprocedureremove()
        //{

        //}


        //    private static void CallStoredProcwithSQLParamater_insert()
        //    {
        //        var ctx = new traningtsqlContext();
        //        var param = new SqlParameter[] {
        //           new SqlParameter() {
        //                 ParameterName = "@empno",
        //             SqlDbType = System.Data.SqlDbType.Int,
        //                   Size = 100,
        //                   Direction = System.Data.
        //            ParameterDirection.Input,
        //                   Value = 2456
        //            },

        //          new SqlParameter() {
        //             ParameterName = "@ename",
        //            SqlDbType = System.Data.
        //                SqlDbType.VarChar,
        //                  Size = 100,
        //               Direction = System.Data.
        //                ParameterDirection.Input,
        //                 Value = "richa"},


        //       new SqlParameter() {
        //        ParameterName = "@sal",
        //        SqlDbType = System.Data.
        //          SqlDbType.Decimal,
        //        Size = 100,
        //       Direction = System.Data.
        //      ParameterDirection.Input,
        //         Value = "1000"},

        //        new SqlParameter() {
        //        ParameterName = "@DEPTNO",
        //        SqlDbType = System.Data.
        //        SqlDbType.Decimal,
        //        Size = 100,
        //       Direction = System.Data.
        //      ParameterDirection.Input,
        //         Value = "656"}


        //      };


        //        try
        //        {
        //            var result = ctx.Database.ExecuteSqlRaw("addemployee12 @empno, @ename, @sal,@DEPTNO", param);
        //            Console.WriteLine("added");
        //        }
        //        catch (Exception ex)
        //        {


        //            throw;
        //        }

        //        Console.WriteLine("update successful");


        //    }





        //}

    }
}
