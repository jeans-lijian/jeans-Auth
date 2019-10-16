using Jeans.User.API.Models.Account;
using Jeans.User.Core.Domain.Account;
using System;
using System.Collections.Generic;

namespace Jeans.User.API.Controllers.MapExtensions
{
    public static class UsersExtenstion
    {
        public static List<UserResponse> ToModel(this List<Users> source)
        {
            var result = new List<UserResponse>();
            foreach (var item in source)
            {
                var entity = new UserResponse
                {
                    Id = item.Id,
                    EmpNo = item.EmpNo,
                    Name = item.Name,
                    Card = item.Card,
                    Sex = item.Sex,
                    ImgUrl = item.ImgUrl,
                    Birthday = item.Birthday?.ToString("yyyy-MM-dd"),
                    Email = item.Email,
                    Department = item.Department,
                    Room = item.Room,
                    Job = item.Job,
                    JobAddress = item.JobAddress,
                    JobName = item.JobName,
                    School = item.School,
                    Education = item.Education,
                    InductionDate = item.InductionDate?.ToString("yyyy-MM-dd"),
                    ResignDate = item.ResignDate?.ToString("yyyy-MM-dd HH:mm:ss"),
                    MobilePhone = item.MobilePhone,
                    OfficePhone = item.OfficePhone,
                    HealthStatus = item.HealthStatus,
                    Nationality = item.Nationality,
                    IsUsed = item.IsUsed,
                    CreateDate = item.CreateDate.ToString("yyyy-MM-dd HH:mm:ss"),
                    CreatePerson = item.CreatePerson,
                    ModifyDate = item.ModifyDate.ToString("yyyy-MM-dd HH:mm:ss"),
                    ModifyPerson = item.ModifyPerson
                };

                result.Add(entity);
            }

            return result;
        }

        public static Users ToEntity(this UserRequest source)
        {
            var entity = new Users
            {
                EmpNo = source.EmpNo,
                Name = source.Name,
                Card = source.Card,
                Sex = source.Sex,
                ImgUrl = source.ImgUrl,
                Birthday = source.Birthday,
                Email = source.Email,
                Department = source.Department,
                Room = source.Room,
                Job = source.Job,
                JobAddress = source.JobAddress,
                JobName = source.JobName,
                School = source.School,
                Education = source.Education,
                InductionDate = source.InductionDate,
                ResignDate = source.ResignDate,
                MobilePhone = source.MobilePhone,
                OfficePhone = source.OfficePhone,
                HealthStatus = source.HealthStatus,
                Nationality = source.Nationality,
                IsUsed = source.IsUsed,
                CreateDate = DateTime.Now,
                CreatePerson = source.EmpNo,
                ModifyDate = DateTime.Now,
                ModifyPerson = source.EmpNo
            };

            return entity;
        }
    }
}