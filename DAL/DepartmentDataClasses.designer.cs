﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="EmployeeTracking")]
	public partial class DepartmentDataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDepartment(Department instance);
    partial void UpdateDepartment(Department instance);
    partial void DeleteDepartment(Department instance);
    #endregion
		
		public DepartmentDataClassesDataContext() : 
				base(global::DAL.Properties.Settings.Default.EmployeeTrackingConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DepartmentDataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DepartmentDataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DepartmentDataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DepartmentDataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Department> Departments
		{
			get
			{
				return this.GetTable<Department>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Department")]
	public partial class Department : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _DepartmentID;
		
		private string _DepartmentName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDepartmentIDChanging(int value);
    partial void OnDepartmentIDChanged();
    partial void OnDepartmentNameChanging(string value);
    partial void OnDepartmentNameChanged();
    #endregion
		
		public Department()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepartmentID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int DepartmentID
		{
			get
			{
				return this._DepartmentID;
			}
			set
			{
				if ((this._DepartmentID != value))
				{
					this.OnDepartmentIDChanging(value);
					this.SendPropertyChanging();
					this._DepartmentID = value;
					this.SendPropertyChanged("DepartmentID");
					this.OnDepartmentIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepartmentName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string DepartmentName
		{
			get
			{
				return this._DepartmentName;
			}
			set
			{
				if ((this._DepartmentName != value))
				{
					this.OnDepartmentNameChanging(value);
					this.SendPropertyChanging();
					this._DepartmentName = value;
					this.SendPropertyChanged("DepartmentName");
					this.OnDepartmentNameChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591