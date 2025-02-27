﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Bai4
    {
        public class Employee
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
        }

        [TestFixture]
        public class EmployeeTests
        {
            private List<Employee> _employees;

            [SetUp]
            public void SetUp()
            {
                _employees = new List<Employee>
        {
            new Employee { Id = 1, FirstName = "Nhất", LastName = "Nguyễn", Email = "nguyenthanhnhat0504@gmail.com" },
            new Employee { Id = 2, FirstName = "Huyền", LastName = "Hà", Email = "HaHuyen@gmail.com" }
        };
            }

            [Test]
            public void TestAddEmployee()
            {
                var newEmployee = new Employee { Id = 3, FirstName = "Nam", LastName = "Nguyễn", Email = "NguyeNam@gmail.com" };
                _employees.Add(newEmployee);
                Assert.That(_employees.Count, Is.EqualTo(3));
            }

            [Test]
            public void TestUpdateEmployee()
            {
                var employee = _employees.Find(e => e.Id == 1);
                employee.Email = "NguyenThanhNhat@gmail.com";
                Assert.That(employee.Email, Is.EqualTo("NguyenThanhNhat@gmail.com"));
            }

            [Test]
            public void TestDeleteEmployee()
            {
                var employee = _employees.Find(e => e.Id == 2);
                _employees.Remove(employee);
                Assert.That(_employees.Count, Is.EqualTo(1));
            }
        }
    }
}
