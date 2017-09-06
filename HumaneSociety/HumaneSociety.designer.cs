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

namespace HumaneSociety
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="HumaneSociety")]
	public partial class HumaneSocietyDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertApproved_Adoption(Approved_Adoption instance);
    partial void UpdateApproved_Adoption(Approved_Adoption instance);
    partial void DeleteApproved_Adoption(Approved_Adoption instance);
    partial void InsertEmployee(Employee instance);
    partial void UpdateEmployee(Employee instance);
    partial void DeleteEmployee(Employee instance);
    partial void InsertAdopter(Adopter instance);
    partial void UpdateAdopter(Adopter instance);
    partial void DeleteAdopter(Adopter instance);
    partial void InsertAnimal(Animal instance);
    partial void UpdateAnimal(Animal instance);
    partial void DeleteAnimal(Animal instance);
    #endregion
		
		public HumaneSocietyDataContext() : 
				base(global::HumaneSociety.Properties.Settings.Default.HumaneSocietyConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public HumaneSocietyDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HumaneSocietyDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HumaneSocietyDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HumaneSocietyDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Approved_Adoption> Approved_Adoptions
		{
			get
			{
				return this.GetTable<Approved_Adoption>();
			}
		}
		
		public System.Data.Linq.Table<Employee> Employees
		{
			get
			{
				return this.GetTable<Employee>();
			}
		}
		
		public System.Data.Linq.Table<Adopter> Adopters
		{
			get
			{
				return this.GetTable<Adopter>();
			}
		}
		
		public System.Data.Linq.Table<Animal> Animals
		{
			get
			{
				return this.GetTable<Animal>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Approved_Adoption")]
	public partial class Approved_Adoption : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Adopter_ID;
		
		private int _Animal_ID;
		
		private string _Adoption_Approval;
		
		private EntityRef<Adopter> _Adopter;
		
		private EntityRef<Animal> _Animal;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAdopter_IDChanging(int value);
    partial void OnAdopter_IDChanged();
    partial void OnAnimal_IDChanging(int value);
    partial void OnAnimal_IDChanged();
    partial void OnAdoption_ApprovalChanging(string value);
    partial void OnAdoption_ApprovalChanged();
    #endregion
		
		public Approved_Adoption()
		{
			this._Adopter = default(EntityRef<Adopter>);
			this._Animal = default(EntityRef<Animal>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Adopter_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Adopter_ID
		{
			get
			{
				return this._Adopter_ID;
			}
			set
			{
				if ((this._Adopter_ID != value))
				{
					if (this._Adopter.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAdopter_IDChanging(value);
					this.SendPropertyChanging();
					this._Adopter_ID = value;
					this.SendPropertyChanged("Adopter_ID");
					this.OnAdopter_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Animal_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Animal_ID
		{
			get
			{
				return this._Animal_ID;
			}
			set
			{
				if ((this._Animal_ID != value))
				{
					if (this._Animal.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAnimal_IDChanging(value);
					this.SendPropertyChanging();
					this._Animal_ID = value;
					this.SendPropertyChanged("Animal_ID");
					this.OnAnimal_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Adoption_Approval", DbType="VarChar(50)")]
		public string Adoption_Approval
		{
			get
			{
				return this._Adoption_Approval;
			}
			set
			{
				if ((this._Adoption_Approval != value))
				{
					this.OnAdoption_ApprovalChanging(value);
					this.SendPropertyChanging();
					this._Adoption_Approval = value;
					this.SendPropertyChanged("Adoption_Approval");
					this.OnAdoption_ApprovalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Adopter_Approved_Adoption", Storage="_Adopter", ThisKey="Adopter_ID", OtherKey="Adopter_ID", IsForeignKey=true)]
		public Adopter Adopter
		{
			get
			{
				return this._Adopter.Entity;
			}
			set
			{
				Adopter previousValue = this._Adopter.Entity;
				if (((previousValue != value) 
							|| (this._Adopter.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Adopter.Entity = null;
						previousValue.Approved_Adoptions.Remove(this);
					}
					this._Adopter.Entity = value;
					if ((value != null))
					{
						value.Approved_Adoptions.Add(this);
						this._Adopter_ID = value.Adopter_ID;
					}
					else
					{
						this._Adopter_ID = default(int);
					}
					this.SendPropertyChanged("Adopter");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Animal_Approved_Adoption", Storage="_Animal", ThisKey="Animal_ID", OtherKey="Animal_ID", IsForeignKey=true)]
		public Animal Animal
		{
			get
			{
				return this._Animal.Entity;
			}
			set
			{
				Animal previousValue = this._Animal.Entity;
				if (((previousValue != value) 
							|| (this._Animal.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Animal.Entity = null;
						previousValue.Approved_Adoptions.Remove(this);
					}
					this._Animal.Entity = value;
					if ((value != null))
					{
						value.Approved_Adoptions.Add(this);
						this._Animal_ID = value.Animal_ID;
					}
					else
					{
						this._Animal_ID = default(int);
					}
					this.SendPropertyChanged("Animal");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Employees")]
	public partial class Employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _LastName;
		
		private string _FirstName;
		
		private int _User_ID;
		
		private string _Pass;
		
		private int _Employee_ID;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnUser_IDChanging(int value);
    partial void OnUser_IDChanged();
    partial void OnPassChanging(string value);
    partial void OnPassChanged();
    partial void OnEmployee_IDChanging(int value);
    partial void OnEmployee_IDChanged();
    #endregion
		
		public Employee()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(50)")]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(50)")]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_ID", DbType="Int NOT NULL")]
		public int User_ID
		{
			get
			{
				return this._User_ID;
			}
			set
			{
				if ((this._User_ID != value))
				{
					this.OnUser_IDChanging(value);
					this.SendPropertyChanging();
					this._User_ID = value;
					this.SendPropertyChanged("User_ID");
					this.OnUser_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pass", DbType="VarChar(50)")]
		public string Pass
		{
			get
			{
				return this._Pass;
			}
			set
			{
				if ((this._Pass != value))
				{
					this.OnPassChanging(value);
					this.SendPropertyChanging();
					this._Pass = value;
					this.SendPropertyChanged("Pass");
					this.OnPassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Employee_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Employee_ID
		{
			get
			{
				return this._Employee_ID;
			}
			set
			{
				if ((this._Employee_ID != value))
				{
					this.OnEmployee_IDChanging(value);
					this.SendPropertyChanging();
					this._Employee_ID = value;
					this.SendPropertyChanged("Employee_ID");
					this.OnEmployee_IDChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Adopter")]
	public partial class Adopter : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Adopter_ID;
		
		private string _Name;
		
		private string _Address;
		
		private string _City;
		
		private string _State;
		
		private System.Nullable<int> _ZipCode;
		
		private System.Nullable<int> _PhoneNumber;
		
		private string _UserName;
		
		private string _Pass;
		
		private EntitySet<Approved_Adoption> _Approved_Adoptions;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAdopter_IDChanging(int value);
    partial void OnAdopter_IDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnAddressChanging(string value);
    partial void OnAddressChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnStateChanging(string value);
    partial void OnStateChanged();
    partial void OnZipCodeChanging(System.Nullable<int> value);
    partial void OnZipCodeChanged();
    partial void OnPhoneNumberChanging(System.Nullable<int> value);
    partial void OnPhoneNumberChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnPassChanging(string value);
    partial void OnPassChanged();
    #endregion
		
		public Adopter()
		{
			this._Approved_Adoptions = new EntitySet<Approved_Adoption>(new Action<Approved_Adoption>(this.attach_Approved_Adoptions), new Action<Approved_Adoption>(this.detach_Approved_Adoptions));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Adopter_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Adopter_ID
		{
			get
			{
				return this._Adopter_ID;
			}
			set
			{
				if ((this._Adopter_ID != value))
				{
					this.OnAdopter_IDChanging(value);
					this.SendPropertyChanging();
					this._Adopter_ID = value;
					this.SendPropertyChanged("Adopter_ID");
					this.OnAdopter_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Address", DbType="VarChar(50)")]
		public string Address
		{
			get
			{
				return this._Address;
			}
			set
			{
				if ((this._Address != value))
				{
					this.OnAddressChanging(value);
					this.SendPropertyChanging();
					this._Address = value;
					this.SendPropertyChanged("Address");
					this.OnAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="VarChar(50)")]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State", DbType="VarChar(50)")]
		public string State
		{
			get
			{
				return this._State;
			}
			set
			{
				if ((this._State != value))
				{
					this.OnStateChanging(value);
					this.SendPropertyChanging();
					this._State = value;
					this.SendPropertyChanged("State");
					this.OnStateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ZipCode", DbType="Int")]
		public System.Nullable<int> ZipCode
		{
			get
			{
				return this._ZipCode;
			}
			set
			{
				if ((this._ZipCode != value))
				{
					this.OnZipCodeChanging(value);
					this.SendPropertyChanging();
					this._ZipCode = value;
					this.SendPropertyChanged("ZipCode");
					this.OnZipCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumber", DbType="Int")]
		public System.Nullable<int> PhoneNumber
		{
			get
			{
				return this._PhoneNumber;
			}
			set
			{
				if ((this._PhoneNumber != value))
				{
					this.OnPhoneNumberChanging(value);
					this.SendPropertyChanging();
					this._PhoneNumber = value;
					this.SendPropertyChanged("PhoneNumber");
					this.OnPhoneNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(50)")]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pass", DbType="VarChar(50)")]
		public string Pass
		{
			get
			{
				return this._Pass;
			}
			set
			{
				if ((this._Pass != value))
				{
					this.OnPassChanging(value);
					this.SendPropertyChanging();
					this._Pass = value;
					this.SendPropertyChanged("Pass");
					this.OnPassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Adopter_Approved_Adoption", Storage="_Approved_Adoptions", ThisKey="Adopter_ID", OtherKey="Adopter_ID")]
		public EntitySet<Approved_Adoption> Approved_Adoptions
		{
			get
			{
				return this._Approved_Adoptions;
			}
			set
			{
				this._Approved_Adoptions.Assign(value);
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
		
		private void attach_Approved_Adoptions(Approved_Adoption entity)
		{
			this.SendPropertyChanging();
			entity.Adopter = this;
		}
		
		private void detach_Approved_Adoptions(Approved_Adoption entity)
		{
			this.SendPropertyChanging();
			entity.Adopter = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Animals")]
	public partial class Animal : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Animal_ID;
		
		private string _Name;
		
		private string _Breed;
		
		private System.Nullable<int> _Age;
		
		private string _Gender;
		
		private string _Personality;
		
		private string _Color;
		
		private System.Nullable<int> _Adoption_Price;
		
		private string _Shots;
		
		private string _Animal_Type;
		
		private System.Nullable<int> _Food;
		
		private System.Nullable<int> _Room;
		
		private string _Adopted;
		
		private EntitySet<Approved_Adoption> _Approved_Adoptions;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAnimal_IDChanging(int value);
    partial void OnAnimal_IDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnBreedChanging(string value);
    partial void OnBreedChanged();
    partial void OnAgeChanging(System.Nullable<int> value);
    partial void OnAgeChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    partial void OnPersonalityChanging(string value);
    partial void OnPersonalityChanged();
    partial void OnColorChanging(string value);
    partial void OnColorChanged();
    partial void OnAdoption_PriceChanging(System.Nullable<int> value);
    partial void OnAdoption_PriceChanged();
    partial void OnShotsChanging(string value);
    partial void OnShotsChanged();
    partial void OnAnimal_TypeChanging(string value);
    partial void OnAnimal_TypeChanged();
    partial void OnFoodChanging(System.Nullable<int> value);
    partial void OnFoodChanged();
    partial void OnRoomChanging(System.Nullable<int> value);
    partial void OnRoomChanged();
    partial void OnAdoptedChanging(string value);
    partial void OnAdoptedChanged();
    #endregion
		
		public Animal()
		{
			this._Approved_Adoptions = new EntitySet<Approved_Adoption>(new Action<Approved_Adoption>(this.attach_Approved_Adoptions), new Action<Approved_Adoption>(this.detach_Approved_Adoptions));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Animal_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Animal_ID
		{
			get
			{
				return this._Animal_ID;
			}
			set
			{
				if ((this._Animal_ID != value))
				{
					this.OnAnimal_IDChanging(value);
					this.SendPropertyChanging();
					this._Animal_ID = value;
					this.SendPropertyChanged("Animal_ID");
					this.OnAnimal_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Breed", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Breed
		{
			get
			{
				return this._Breed;
			}
			set
			{
				if ((this._Breed != value))
				{
					this.OnBreedChanging(value);
					this.SendPropertyChanging();
					this._Breed = value;
					this.SendPropertyChanged("Breed");
					this.OnBreedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Age", DbType="Int")]
		public System.Nullable<int> Age
		{
			get
			{
				return this._Age;
			}
			set
			{
				if ((this._Age != value))
				{
					this.OnAgeChanging(value);
					this.SendPropertyChanging();
					this._Age = value;
					this.SendPropertyChanged("Age");
					this.OnAgeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Personality", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Personality
		{
			get
			{
				return this._Personality;
			}
			set
			{
				if ((this._Personality != value))
				{
					this.OnPersonalityChanging(value);
					this.SendPropertyChanging();
					this._Personality = value;
					this.SendPropertyChanged("Personality");
					this.OnPersonalityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Color", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Color
		{
			get
			{
				return this._Color;
			}
			set
			{
				if ((this._Color != value))
				{
					this.OnColorChanging(value);
					this.SendPropertyChanging();
					this._Color = value;
					this.SendPropertyChanged("Color");
					this.OnColorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Adoption_Price", DbType="Int")]
		public System.Nullable<int> Adoption_Price
		{
			get
			{
				return this._Adoption_Price;
			}
			set
			{
				if ((this._Adoption_Price != value))
				{
					this.OnAdoption_PriceChanging(value);
					this.SendPropertyChanging();
					this._Adoption_Price = value;
					this.SendPropertyChanged("Adoption_Price");
					this.OnAdoption_PriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Shots", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Shots
		{
			get
			{
				return this._Shots;
			}
			set
			{
				if ((this._Shots != value))
				{
					this.OnShotsChanging(value);
					this.SendPropertyChanging();
					this._Shots = value;
					this.SendPropertyChanged("Shots");
					this.OnShotsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Animal_Type", DbType="VarChar(50)")]
		public string Animal_Type
		{
			get
			{
				return this._Animal_Type;
			}
			set
			{
				if ((this._Animal_Type != value))
				{
					this.OnAnimal_TypeChanging(value);
					this.SendPropertyChanging();
					this._Animal_Type = value;
					this.SendPropertyChanged("Animal_Type");
					this.OnAnimal_TypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Food", DbType="Int")]
		public System.Nullable<int> Food
		{
			get
			{
				return this._Food;
			}
			set
			{
				if ((this._Food != value))
				{
					this.OnFoodChanging(value);
					this.SendPropertyChanging();
					this._Food = value;
					this.SendPropertyChanged("Food");
					this.OnFoodChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Room", DbType="Int")]
		public System.Nullable<int> Room
		{
			get
			{
				return this._Room;
			}
			set
			{
				if ((this._Room != value))
				{
					this.OnRoomChanging(value);
					this.SendPropertyChanging();
					this._Room = value;
					this.SendPropertyChanged("Room");
					this.OnRoomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Adopted", DbType="VarChar(50)")]
		public string Adopted
		{
			get
			{
				return this._Adopted;
			}
			set
			{
				if ((this._Adopted != value))
				{
					this.OnAdoptedChanging(value);
					this.SendPropertyChanging();
					this._Adopted = value;
					this.SendPropertyChanged("Adopted");
					this.OnAdoptedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Animal_Approved_Adoption", Storage="_Approved_Adoptions", ThisKey="Animal_ID", OtherKey="Animal_ID")]
		public EntitySet<Approved_Adoption> Approved_Adoptions
		{
			get
			{
				return this._Approved_Adoptions;
			}
			set
			{
				this._Approved_Adoptions.Assign(value);
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
		
		private void attach_Approved_Adoptions(Approved_Adoption entity)
		{
			this.SendPropertyChanging();
			entity.Animal = this;
		}
		
		private void detach_Approved_Adoptions(Approved_Adoption entity)
		{
			this.SendPropertyChanging();
			entity.Animal = null;
		}
	}
}
#pragma warning restore 1591
