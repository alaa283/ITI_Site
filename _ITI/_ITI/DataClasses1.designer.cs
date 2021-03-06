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

namespace _ITI
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ITI_DataBase")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertQuestions_Answer(Questions_Answer instance);
    partial void UpdateQuestions_Answer(Questions_Answer instance);
    partial void DeleteQuestions_Answer(Questions_Answer instance);
    partial void InsertStudent(Student instance);
    partial void UpdateStudent(Student instance);
    partial void DeleteStudent(Student instance);
    partial void InsertCourse(Course instance);
    partial void UpdateCourse(Course instance);
    partial void DeleteCourse(Course instance);
    partial void InsertLogin(Login instance);
    partial void UpdateLogin(Login instance);
    partial void DeleteLogin(Login instance);
    partial void InsertRegister(Register instance);
    partial void UpdateRegister(Register instance);
    partial void DeleteRegister(Register instance);
    partial void InsertStaff(Staff instance);
    partial void UpdateStaff(Staff instance);
    partial void DeleteStaff(Staff instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ITI_DataBaseConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Questions_Answer> Questions_Answers
		{
			get
			{
				return this.GetTable<Questions_Answer>();
			}
		}
		
		public System.Data.Linq.Table<Student> Students
		{
			get
			{
				return this.GetTable<Student>();
			}
		}
		
		public System.Data.Linq.Table<Course> Courses
		{
			get
			{
				return this.GetTable<Course>();
			}
		}
		
		public System.Data.Linq.Table<Login> Logins
		{
			get
			{
				return this.GetTable<Login>();
			}
		}
		
		public System.Data.Linq.Table<Staff_Ask> Staff_Asks
		{
			get
			{
				return this.GetTable<Staff_Ask>();
			}
		}
		
		public System.Data.Linq.Table<staff_student> staff_students
		{
			get
			{
				return this.GetTable<staff_student>();
			}
		}
		
		public System.Data.Linq.Table<Register> Registers
		{
			get
			{
				return this.GetTable<Register>();
			}
		}
		
		public System.Data.Linq.Table<Staff> Staffs
		{
			get
			{
				return this.GetTable<Staff>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Questions&Answers]")]
	public partial class Questions_Answer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		[Required]
		private int _Id_Ask;
        [Required]
        private string _Ask;
        
        private string _Answer;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_AskChanging(int value);
    partial void OnId_AskChanged();
    partial void OnAskChanging(string value);
    partial void OnAskChanged();
    partial void OnAnswerChanging(string value);
    partial void OnAnswerChanged();
    #endregion
		
		public Questions_Answer()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Ask", DbType="Int NOT NULL", IsPrimaryKey=true)]
        [Required]
        public int Id_Ask
		{
			get
			{
				return this._Id_Ask;
			}
			set
			{
				if ((this._Id_Ask != value))
				{
					this.OnId_AskChanging(value);
					this.SendPropertyChanging();
					this._Id_Ask = value;
					this.SendPropertyChanged("Id_Ask");
					this.OnId_AskChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ask", DbType="VarChar(1000)")]
        [Required]
        public string Ask
		{
			get
			{
				return this._Ask;
			}
			set
			{
				if ((this._Ask != value))
				{
					this.OnAskChanging(value);
					this.SendPropertyChanging();
					this._Ask = value;
					this.SendPropertyChanged("Ask");
					this.OnAskChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Answer", DbType="VarChar(1000)")]
		public string Answer
		{
			get
			{
				return this._Answer;
			}
			set
			{
				if ((this._Answer != value))
				{
					this.OnAnswerChanging(value);
					this.SendPropertyChanging();
					this._Answer = value;
					this.SendPropertyChanged("Answer");
					this.OnAnswerChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Student")]
	public partial class Student : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		[Required]
		private int _Id_Student;
        [Required]
        private string _Email_Student;
        [Required]
        private string _Name;
        [Required]
        private System.Nullable<int> _Phone;
        [Required]
        private string _Gender;
		
		private System.Nullable<int> _Id_Courses;
		
		private string _city;
		
		private string _faculty;
		
		private string _specialization;
		
		private string _graduation_year;
		
		private EntityRef<Login> _Login;
		
		private EntityRef<Course> _Course;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_StudentChanging(int value);
    partial void OnId_StudentChanged();
    partial void OnEmail_StudentChanging(string value);
    partial void OnEmail_StudentChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPhoneChanging(System.Nullable<int> value);
    partial void OnPhoneChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    partial void OnId_CoursesChanging(System.Nullable<int> value);
    partial void OnId_CoursesChanged();
    partial void OncityChanging(string value);
    partial void OncityChanged();
    partial void OnfacultyChanging(string value);
    partial void OnfacultyChanged();
    partial void OnspecializationChanging(string value);
    partial void OnspecializationChanged();
    partial void Ongraduation_yearChanging(string value);
    partial void Ongraduation_yearChanged();
    #endregion
		
		public Student()
		{
			this._Login = default(EntityRef<Login>);
			this._Course = default(EntityRef<Course>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Student", DbType="Int NOT NULL", IsPrimaryKey=true)]
        [Required]
        public int Id_Student
		{
			get
			{
				return this._Id_Student;
			}
			set
			{
				if ((this._Id_Student != value))
				{
					this.OnId_StudentChanging(value);
					this.SendPropertyChanging();
					this._Id_Student = value;
					this.SendPropertyChanged("Id_Student");
					this.OnId_StudentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email_Student", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
        [Required]
        public string Email_Student
		{
			get
			{
				return this._Email_Student;
			}
			set
			{
				if ((this._Email_Student != value))
				{
					this.OnEmail_StudentChanging(value);
					this.SendPropertyChanging();
					this._Email_Student = value;
					this.SendPropertyChanged("Email_Student");
					this.OnEmail_StudentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
        [Required]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="Int")]
        [Required]
        public System.Nullable<int> Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="VarChar(6) NOT NULL", CanBeNull=false)]
        [Required]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Courses", DbType="Int")]
		public System.Nullable<int> Id_Courses
		{
			get
			{
				return this._Id_Courses;
			}
			set
			{
				if ((this._Id_Courses != value))
				{
					if (this._Course.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnId_CoursesChanging(value);
					this.SendPropertyChanging();
					this._Id_Courses = value;
					this.SendPropertyChanged("Id_Courses");
					this.OnId_CoursesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_city", DbType="VarChar(50)")]
		public string city
		{
			get
			{
				return this._city;
			}
			set
			{
				if ((this._city != value))
				{
					this.OncityChanging(value);
					this.SendPropertyChanging();
					this._city = value;
					this.SendPropertyChanged("city");
					this.OncityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_faculty", DbType="VarChar(50)")]
		public string faculty
		{
			get
			{
				return this._faculty;
			}
			set
			{
				if ((this._faculty != value))
				{
					this.OnfacultyChanging(value);
					this.SendPropertyChanging();
					this._faculty = value;
					this.SendPropertyChanged("faculty");
					this.OnfacultyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_specialization", DbType="VarChar(50)")]
		public string specialization
		{
			get
			{
				return this._specialization;
			}
			set
			{
				if ((this._specialization != value))
				{
					this.OnspecializationChanging(value);
					this.SendPropertyChanging();
					this._specialization = value;
					this.SendPropertyChanged("specialization");
					this.OnspecializationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_graduation_year", DbType="VarChar(50)")]
		public string graduation_year
		{
			get
			{
				return this._graduation_year;
			}
			set
			{
				if ((this._graduation_year != value))
				{
					this.Ongraduation_yearChanging(value);
					this.SendPropertyChanging();
					this._graduation_year = value;
					this.SendPropertyChanged("graduation_year");
					this.Ongraduation_yearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Student_Login", Storage="_Login", ThisKey="Id_Student", OtherKey="Password", IsUnique=true, IsForeignKey=false)]
		public Login Login
		{
			get
			{
				return this._Login.Entity;
			}
			set
			{
				Login previousValue = this._Login.Entity;
				if (((previousValue != value) 
							|| (this._Login.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Login.Entity = null;
						previousValue.Student = null;
					}
					this._Login.Entity = value;
					if ((value != null))
					{
						value.Student = this;
					}
					this.SendPropertyChanged("Login");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Course_Student", Storage="_Course", ThisKey="Id_Courses", OtherKey="Id_Courses", IsForeignKey=true, DeleteRule="CASCADE")]
		public Course Course
		{
			get
			{
				return this._Course.Entity;
			}
			set
			{
				Course previousValue = this._Course.Entity;
				if (((previousValue != value) 
							|| (this._Course.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Course.Entity = null;
						previousValue.Students.Remove(this);
					}
					this._Course.Entity = value;
					if ((value != null))
					{
						value.Students.Add(this);
						this._Id_Courses = value.Id_Courses;
					}
					else
					{
						this._Id_Courses = default(Nullable<int>);
					}
					this.SendPropertyChanged("Course");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Courses")]
	public partial class Course : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		[Required]
		private int _Id_Courses;
        [Required]
        private string _Name;
        [Required]
        private int _Date;
        [Required]
        private string _Concept;
		
		private EntitySet<Student> _Students;
		
		private EntitySet<Staff> _Staffs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_CoursesChanging(int value);
    partial void OnId_CoursesChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDateChanging(int value);
    partial void OnDateChanged();
    partial void OnConceptChanging(string value);
    partial void OnConceptChanged();
    #endregion
		
		public Course()
		{
			this._Students = new EntitySet<Student>(new Action<Student>(this.attach_Students), new Action<Student>(this.detach_Students));
			this._Staffs = new EntitySet<Staff>(new Action<Staff>(this.attach_Staffs), new Action<Staff>(this.detach_Staffs));
			OnCreated();
		}


        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Courses", DbType="Int NOT NULL", IsPrimaryKey=true)]
        [Required]
        public int Id_Courses
		{
			get
			{
				return this._Id_Courses;
			}
			set
			{
				if ((this._Id_Courses != value))
				{
					this.OnId_CoursesChanging(value);
					this.SendPropertyChanging();
					this._Id_Courses = value;
					this.SendPropertyChanged("Id_Courses");
					this.OnId_CoursesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
        [Required]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="Int NOT NULL")]
        [Required]
        public int Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Concept", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
        [Required]
        public string Concept
		{
			get
			{
				return this._Concept;
			}
			set
			{
				if ((this._Concept != value))
				{
					this.OnConceptChanging(value);
					this.SendPropertyChanging();
					this._Concept = value;
					this.SendPropertyChanged("Concept");
					this.OnConceptChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Course_Student", Storage="_Students", ThisKey="Id_Courses", OtherKey="Id_Courses")]
		public EntitySet<Student> Students
		{
			get
			{
				return this._Students;
			}
			set
			{
				this._Students.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Course_Staff", Storage="_Staffs", ThisKey="Id_Courses", OtherKey="Id_Courses")]
		public EntitySet<Staff> Staffs
		{
			get
			{
				return this._Staffs;
			}
			set
			{
				this._Staffs.Assign(value);
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
		
		private void attach_Students(Student entity)
		{
			this.SendPropertyChanging();
			entity.Course = this;
		}
		
		private void detach_Students(Student entity)
		{
			this.SendPropertyChanging();
			entity.Course = null;
		}
		
		private void attach_Staffs(Staff entity)
		{
			this.SendPropertyChanging();
			entity.Course = this;
		}
		
		private void detach_Staffs(Staff entity)
		{
			this.SendPropertyChanging();
			entity.Course = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Login")]
	public partial class Login : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Password;
		
		private int _Id_Student;
		
		private int _Id_Staff;
		
		private string _Name;
		
		private EntityRef<Student> _Student;
		
		private EntityRef<Staff> _Staff;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnPasswordChanging(int value);
    partial void OnPasswordChanged();
    partial void OnId_StudentChanging(int value);
    partial void OnId_StudentChanged();
    partial void OnId_StaffChanging(int value);
    partial void OnId_StaffChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public Login()
		{
			this._Student = default(EntityRef<Student>);
			this._Staff = default(EntityRef<Staff>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					if ((this._Student.HasLoadedOrAssignedValue || this._Staff.HasLoadedOrAssignedValue))
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Student", DbType="Int NOT NULL")]
		public int Id_Student
		{
			get
			{
				return this._Id_Student;
			}
			set
			{
				if ((this._Id_Student != value))
				{
					this.OnId_StudentChanging(value);
					this.SendPropertyChanging();
					this._Id_Student = value;
					this.SendPropertyChanged("Id_Student");
					this.OnId_StudentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Staff", DbType="Int NOT NULL")]
		public int Id_Staff
		{
			get
			{
				return this._Id_Staff;
			}
			set
			{
				if ((this._Id_Staff != value))
				{
					this.OnId_StaffChanging(value);
					this.SendPropertyChanging();
					this._Id_Staff = value;
					this.SendPropertyChanged("Id_Staff");
					this.OnId_StaffChanged();
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Student_Login", Storage="_Student", ThisKey="Password", OtherKey="Id_Student", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public Student Student
		{
			get
			{
				return this._Student.Entity;
			}
			set
			{
				Student previousValue = this._Student.Entity;
				if (((previousValue != value) 
							|| (this._Student.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Student.Entity = null;
						previousValue.Login = null;
					}
					this._Student.Entity = value;
					if ((value != null))
					{
						value.Login = this;
						this._Password = value.Id_Student;
					}
					else
					{
						this._Password = default(int);
					}
					this.SendPropertyChanged("Student");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Staff_Login", Storage="_Staff", ThisKey="Password", OtherKey="Id_Staff", IsForeignKey=true)]
		public Staff Staff
		{
			get
			{
				return this._Staff.Entity;
			}
			set
			{
				Staff previousValue = this._Staff.Entity;
				if (((previousValue != value) 
							|| (this._Staff.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Staff.Entity = null;
						previousValue.Login = null;
					}
					this._Staff.Entity = value;
					if ((value != null))
					{
						value.Login = this;
						this._Password = value.Id_Staff;
					}
					else
					{
						this._Password = default(int);
					}
					this.SendPropertyChanged("Staff");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Staff&Ask]")]
	public partial class Staff_Ask
	{
		
		private int _Id_Ask;
		
		private int _Id_Staff;
		
		public Staff_Ask()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Ask", DbType="Int NOT NULL")]
		public int Id_Ask
		{
			get
			{
				return this._Id_Ask;
			}
			set
			{
				if ((this._Id_Ask != value))
				{
					this._Id_Ask = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Staff", DbType="Int NOT NULL")]
		public int Id_Staff
		{
			get
			{
				return this._Id_Staff;
			}
			set
			{
				if ((this._Id_Staff != value))
				{
					this._Id_Staff = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[staff&student]")]
	public partial class staff_student
	{
		
		private int _Id_Student;
		
		private int _Id_Ask;
		
		public staff_student()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Student", DbType="Int NOT NULL")]
		public int Id_Student
		{
			get
			{
				return this._Id_Student;
			}
			set
			{
				if ((this._Id_Student != value))
				{
					this._Id_Student = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Ask", DbType="Int NOT NULL")]
		public int Id_Ask
		{
			get
			{
				return this._Id_Ask;
			}
			set
			{
				if ((this._Id_Ask != value))
				{
					this._Id_Ask = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Register")]
	public partial class Register : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Email_Student;
		
		private string _Name;
		
		private int _Phone;
		
		private string _city;
		
		private string _faculty;
		
		private string _specialization;
		
		private string _graduation_year;
		
		private int _Id;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEmail_StudentChanging(string value);
    partial void OnEmail_StudentChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPhoneChanging(int value);
    partial void OnPhoneChanged();
    partial void OncityChanging(string value);
    partial void OncityChanged();
    partial void OnfacultyChanging(string value);
    partial void OnfacultyChanged();
    partial void OnspecializationChanging(string value);
    partial void OnspecializationChanged();
    partial void Ongraduation_yearChanging(string value);
    partial void Ongraduation_yearChanged();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    #endregion
		
		public Register()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email_Student", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Email_Student
		{
			get
			{
				return this._Email_Student;
			}
			set
			{
				if ((this._Email_Student != value))
				{
					this.OnEmail_StudentChanging(value);
					this.SendPropertyChanging();
					this._Email_Student = value;
					this.SendPropertyChanged("Email_Student");
					this.OnEmail_StudentChanged();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="Int NOT NULL")]
		public int Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_city", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string city
		{
			get
			{
				return this._city;
			}
			set
			{
				if ((this._city != value))
				{
					this.OncityChanging(value);
					this.SendPropertyChanging();
					this._city = value;
					this.SendPropertyChanged("city");
					this.OncityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_faculty", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string faculty
		{
			get
			{
				return this._faculty;
			}
			set
			{
				if ((this._faculty != value))
				{
					this.OnfacultyChanging(value);
					this.SendPropertyChanging();
					this._faculty = value;
					this.SendPropertyChanged("faculty");
					this.OnfacultyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_specialization", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string specialization
		{
			get
			{
				return this._specialization;
			}
			set
			{
				if ((this._specialization != value))
				{
					this.OnspecializationChanging(value);
					this.SendPropertyChanging();
					this._specialization = value;
					this.SendPropertyChanged("specialization");
					this.OnspecializationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_graduation_year", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string graduation_year
		{
			get
			{
				return this._graduation_year;
			}
			set
			{
				if ((this._graduation_year != value))
				{
					this.Ongraduation_yearChanging(value);
					this.SendPropertyChanging();
					this._graduation_year = value;
					this.SendPropertyChanged("graduation_year");
					this.Ongraduation_yearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Staff")]
	public partial class Staff : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
        [Required]
        private int _Id_Staff;
        [Required]
        private string _Email_Staff;
        [Required]
        private string _Name;
        [Required]
        private string _Specialization;
        [Required]
        private string _Gender;
        [Required]
        private int _Phone;
		
		private System.Nullable<int> _Id_Courses;
		
		private EntityRef<Login> _Login;
		
		private EntityRef<Course> _Course;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_StaffChanging(int value);
    partial void OnId_StaffChanged();
    partial void OnEmail_StaffChanging(string value);
    partial void OnEmail_StaffChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnSpecializationChanging(string value);
    partial void OnSpecializationChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    partial void OnPhoneChanging(int value);
    partial void OnPhoneChanged();
    partial void OnId_CoursesChanging(System.Nullable<int> value);
    partial void OnId_CoursesChanged();
    #endregion
		
		public Staff()
		{
			this._Login = default(EntityRef<Login>);
			this._Course = default(EntityRef<Course>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Staff", DbType="Int NOT NULL", IsPrimaryKey=true)]
        [Required]
        public int Id_Staff
		{
			get
			{
				return this._Id_Staff;
			}
			set
			{
				if ((this._Id_Staff != value))
				{
					this.OnId_StaffChanging(value);
					this.SendPropertyChanging();
					this._Id_Staff = value;
					this.SendPropertyChanged("Id_Staff");
					this.OnId_StaffChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email_Staff", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
        [Required]
        public string Email_Staff
		{
			get
			{
				return this._Email_Staff;
			}
			set
			{
				if ((this._Email_Staff != value))
				{
					this.OnEmail_StaffChanging(value);
					this.SendPropertyChanging();
					this._Email_Staff = value;
					this.SendPropertyChanged("Email_Staff");
					this.OnEmail_StaffChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
        [Required]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Specialization", DbType="Text NOT NULL", CanBeNull=false, UpdateCheck=UpdateCheck.Never)]
        [Required]
        public string Specialization
		{
			get
			{
				return this._Specialization;
			}
			set
			{
				if ((this._Specialization != value))
				{
					this.OnSpecializationChanging(value);
					this.SendPropertyChanging();
					this._Specialization = value;
					this.SendPropertyChanged("Specialization");
					this.OnSpecializationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="VarChar(6) NOT NULL", CanBeNull=false)]
        [Required]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="Int NOT NULL")]
        [Required]
        public int Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Courses", DbType="Int")]
		public System.Nullable<int> Id_Courses
		{
			get
			{
				return this._Id_Courses;
			}
			set
			{
				if ((this._Id_Courses != value))
				{
					if (this._Course.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnId_CoursesChanging(value);
					this.SendPropertyChanging();
					this._Id_Courses = value;
					this.SendPropertyChanged("Id_Courses");
					this.OnId_CoursesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Staff_Login", Storage="_Login", ThisKey="Id_Staff", OtherKey="Password", IsUnique=true, IsForeignKey=false)]
		public Login Login
		{
			get
			{
				return this._Login.Entity;
			}
			set
			{
				Login previousValue = this._Login.Entity;
				if (((previousValue != value) 
							|| (this._Login.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Login.Entity = null;
						previousValue.Staff = null;
					}
					this._Login.Entity = value;
					if ((value != null))
					{
						value.Staff = this;
					}
					this.SendPropertyChanged("Login");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Course_Staff", Storage="_Course", ThisKey="Id_Courses", OtherKey="Id_Courses", IsForeignKey=true, DeleteRule="CASCADE")]
		public Course Course
		{
			get
			{
				return this._Course.Entity;
			}
			set
			{
				Course previousValue = this._Course.Entity;
				if (((previousValue != value) 
							|| (this._Course.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Course.Entity = null;
						previousValue.Staffs.Remove(this);
					}
					this._Course.Entity = value;
					if ((value != null))
					{
						value.Staffs.Add(this);
						this._Id_Courses = value.Id_Courses;
					}
					else
					{
						this._Id_Courses = default(Nullable<int>);
					}
					this.SendPropertyChanged("Course");
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
