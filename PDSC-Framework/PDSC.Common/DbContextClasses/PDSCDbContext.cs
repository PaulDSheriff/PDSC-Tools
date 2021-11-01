using PDSC.Common.EntityLayer;
using Microsoft.EntityFrameworkCore;

namespace PDSC.Common.DataLayer
{
  /// <summary>
  /// This EF class is used to access all the standard tables in the PDSC Framework
  /// </summary>
  public class PDSCDbContext : DbContext
  {
    public PDSCDbContext(DbContextOptions<PDSCDbContext> options)
        : base(options)
    {
    }
    
    public virtual DbSet<CanadianProvince> CanadianProvinces { get; set; }
    public virtual DbSet<Country> Countries { get; set; }
    public virtual DbSet<ContactUs> ContactUsList { get; set; }
    public virtual DbSet<EmailTemplate> EmailTemplates { get; set; }
    public virtual DbSet<FAQ> Faqs { get; set; }
    public virtual DbSet<LogInfo> LogInfoList { get; set; }
    public virtual DbSet<PersonType> PersonTypes { get; set; }
    public virtual DbSet<PrivacyPolicy> PrivacyPolicies { get; set; }
    public virtual DbSet<SiteTerms> SiteTerms { get; set; }
    public virtual DbSet<USStateCode> USStateCodes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
    }
  }
}
