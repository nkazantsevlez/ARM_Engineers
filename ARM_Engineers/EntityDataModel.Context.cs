﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ARM_Engineers
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class arm_engineersEntities : DbContext
    {
        public arm_engineersEntities()
            : base("name=arm_engineersEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<cartridge> cartridge { get; set; }
        public virtual DbSet<cpu> cpu { get; set; }
        public virtual DbSet<employee> employee { get; set; }
        public virtual DbSet<event_log> event_log { get; set; }
        public virtual DbSet<network_devices> network_devices { get; set; }
        public virtual DbSet<other_devices> other_devices { get; set; }
        public virtual DbSet<pc> pc { get; set; }
        public virtual DbSet<peripherals> peripherals { get; set; }
        public virtual DbSet<printer> printer { get; set; }
        public virtual DbSet<ram> ram { get; set; }
        public virtual DbSet<room> room { get; set; }
        public virtual DbSet<users> users { get; set; }
        public virtual DbSet<event_log_view> event_log_view { get; set; }
        public virtual DbSet<pc_viewsearch> pc_viewsearch { get; set; }
        public virtual DbSet<pc_viewsklad> pc_viewsklad { get; set; }
        public virtual DbSet<cartridge_view> cartridge_view { get; set; }
        public virtual DbSet<cpu_view> cpu_view { get; set; }
        public virtual DbSet<network_devices_view> network_devices_view { get; set; }
        public virtual DbSet<other_devices_view> other_devices_view { get; set; }
        public virtual DbSet<peripherals_view> peripherals_view { get; set; }
        public virtual DbSet<printer_view> printer_view { get; set; }
        public virtual DbSet<ram_view> ram_view { get; set; }
    
        public virtual ObjectResult<users> Check_Login_And_Password(string login, string password)
        {
            var loginParameter = login != null ?
                new ObjectParameter("Login", login) :
                new ObjectParameter("Login", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<users>("Check_Login_And_Password", loginParameter, passwordParameter);
        }
    
        public virtual ObjectResult<users> Check_Login_And_Password(string login, string password, MergeOption mergeOption)
        {
            var loginParameter = login != null ?
                new ObjectParameter("Login", login) :
                new ObjectParameter("Login", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<users>("Check_Login_And_Password", mergeOption, loginParameter, passwordParameter);
        }
    }
}
