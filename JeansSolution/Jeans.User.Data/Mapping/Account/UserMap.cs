using Jeans.User.Core.Domain.Account;
using System.Data.Entity.ModelConfiguration;

namespace Jeans.User.Data.Mapping.Account
{
    public class UserMap : EntityTypeConfiguration<Users>
    {
        public UserMap()
        {
            ToTable("T_USER");
            HasKey(u => u.Id).Property(u => u.Id).HasColumnName("ID");

            Property(u => u.EmpNo).HasColumnName("EMPNO").HasMaxLength(64).IsRequired();
            Property(u => u.Card).HasColumnName("CARD").HasMaxLength(20);
            Property(u => u.Name).HasColumnName("NAME").HasMaxLength(100).IsRequired();
            Property(u => u.Sex).HasColumnName("SEX").HasMaxLength(1);
            Property(u => u.ImgUrl).HasColumnName("IMGURL").HasMaxLength(256);
            Property(u => u.Birthday).HasColumnName("BIRTHDAY");
            Property(u => u.Department).HasColumnName("DEPARTMENT").HasMaxLength(64);
            Property(u => u.Room).HasColumnName("ROOM").HasMaxLength(64);
            Property(u => u.Job).HasColumnName("JOB").HasMaxLength(64);
            Property(u => u.Email).HasColumnName("EMAIL").HasMaxLength(128);
            Property(u => u.MobilePhone).HasColumnName("MOBILEPHONE").HasMaxLength(100);
            Property(u => u.OfficePhone).HasColumnName("OFFICEPHONE").HasMaxLength(100);
            Property(u => u.InductionDate).HasColumnName("INDUCTIONDATE");
            Property(u => u.ResignDate).HasColumnName("RESIGNDATE");
            Property(u => u.School).HasColumnName("SCHOOL").HasMaxLength(128);
            Property(u => u.Education).HasColumnName("EDUCATION").HasMaxLength(32);
            Property(u => u.JobAddress).HasColumnName("JOBADDRESS").HasMaxLength(256);
            Property(u => u.JobName).HasColumnName("JOBNAME").HasMaxLength(32);
            Property(u => u.HealthStatus).HasColumnName("HEALTHSTATUS").HasMaxLength(16);
            Property(u => u.Nationality).HasColumnName("NATIONALITY").HasMaxLength(16);
            Property(u => u.IsUsed).HasColumnName("ISUSED");
            Property(u => u.CreatePerson).HasColumnName("CREATEPERSON").HasMaxLength(32).IsRequired();
            Property(u => u.CreateDate).HasColumnName("CREATEDATE");
            Property(u => u.ModifyPerson).HasColumnName("MODIFYPERSON").HasMaxLength(32).IsRequired();
            Property(u => u.ModifyDate).HasColumnName("MODIFYDATE");
        }
    }
}