using System;
using System.Web.Security;

namespace MembershipBase
{
	/// <summary>
	/// A base class which implements NotImplementedExceptions for the properties 
	/// and methods that are available on MembershipUser.
	/// </summary>
	internal abstract class MembershipUserBase : MembershipUser
	{

		#region MembershipUser Properties

		/// <summary>
		/// Gets or sets application-specific information for the membership user.
		/// </summary>
		public override string Comment
		{
			get { throw new NotImplementedException(); }
			set { throw new NotImplementedException(); }
		}

		/// <summary>
		/// Gets the date and time when the user was added to the membership data store.
		/// </summary>
		public override DateTime CreationDate
		{
			get { throw new NotImplementedException(); }
		}

		/// <summary>
		/// Gets or sets the e-mail address for the membership user.
		/// </summary>
		public override string Email
		{
			get { throw new NotImplementedException(); }
			set { throw new NotImplementedException(); }
		}

		/// <summary>
		/// Gets or sets whether the membership user can be authenticated.
		/// </summary>
		public override bool IsApproved
		{
			get { throw new NotImplementedException(); }
			set { throw new NotImplementedException(); }
		}

		/// <summary>
		/// Gets a value indicating whether the membership user is locked out and unable
		///  to be validated.
		/// </summary>
		public override bool IsLockedOut
		{
			get { throw new NotImplementedException(); }
		}

		/// <summary>
		/// Gets whether the user is currently online.
		/// </summary>
		public override bool IsOnline
		{
			get { throw new NotImplementedException(); }
		}

		/// <summary>
		/// Gets or sets the date and time when the membership user was last authenticated
		/// or accessed the application.
		/// </summary>
		public override DateTime LastActivityDate
		{
			get { throw new NotImplementedException(); }
			set { throw new NotImplementedException(); }
		}

		/// <summary>
		/// Gets the most recent date and time that the membership user was locked out.
		/// </summary>
		public override DateTime LastLockoutDate
		{
			get { throw new NotImplementedException(); }
		}

		/// <summary>
		/// Gets or sets the date and time when the user was last authenticated.
		/// </summary>
		public override DateTime LastLoginDate
		{
			get { throw new NotImplementedException(); }
			set { throw new NotImplementedException(); }
		}

		/// <summary>
		/// Gets the date and time when the membership user's password was last updated.
		/// </summary>
		public override DateTime LastPasswordChangedDate
		{
			get { throw new NotImplementedException(); }
		}

		/// <summary>
		/// Gets the password question for the membership user.
		/// </summary>
		public override string PasswordQuestion
		{
			get { throw new NotImplementedException(); }
		}

		/// <summary>
		/// Gets the name of the membership provider that stores and retrieves user information
		/// for the membership user.
		/// </summary>
		public override string ProviderName
		{
			get { throw new NotImplementedException(); }
		}

		/// <summary>
		/// Gets the user identifier from the membership data source for the user.
		/// </summary>
		public override object ProviderUserKey
		{
			get { throw new NotImplementedException(); }
		}

		/// <summary>
		/// Gets the logon name of the membership user.
		/// </summary>
		public override string UserName
		{
			get { throw new NotImplementedException(); }

		}

		#endregion

		#region MembershipUser Methods

		/// <summary>
		/// Updates the password for the membership user in the membership data store.
		/// </summary>
		/// <param name="oldPassword">The current password for the membership user.</param>
		/// <param name="newPassword">The new password for the membership user.</param>
		/// <returns>true if the update was successful; otherwise, false.</returns>
		public override bool ChangePassword(string oldPassword, string newPassword)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Updates the password question and answer for the membership user in the membership
		/// data store.
		/// </summary>
		/// <param name="password">The current password for the membership user.</param>
		/// <param name="newPasswordQuestion">The new password question value for the membership user.</param>
		/// <param name="newPasswordAnswer">The new password answer value for the membership user.</param>
		/// <returns>true if the update was successful; otherwise, false.</returns>
		public override bool ChangePasswordQuestionAndAnswer(string password, string newPasswordQuestion, string newPasswordAnswer)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Gets the password for the membership user from the membership data store.
		/// </summary>
		/// <returns>The password for the membership user.</returns>
		public override string GetPassword()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Gets the password for the membership user from the membership data store.
		/// </summary>
		/// <param name="passwordAnswer">The password answer for the membership user.</param>
		/// <returns>The password for the membership user.</returns>
		public override string GetPassword(string passwordAnswer)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Resets a user's password to a new, automatically generated password.
		/// </summary>
		/// <returns>The new password for the membership user.</returns>
		public override string ResetPassword()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Resets a user's password to a new, automatically generated password.
		/// </summary>
		/// <param name="passwordAnswer">The password answer for the membership user.</param>
		/// <returns>The new password for the membership user.</returns>
		public override string ResetPassword(string passwordAnswer)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns the user name for the membership user.
		/// </summary>
		/// <returns>The System.Web.Security.MembershipUser.UserName for the membership user.</returns>
		public override string ToString()
		{
			return UserName;
		}

		/// <summary>
		/// Clears the locked-out state of the user so that the membership user can be
		/// validated.
		/// </summary>
		/// <returns>true if the membership user was successfully unlocked; otherwise, false.</returns>
		public override bool UnlockUser()
		{
			throw new NotImplementedException();
		}

		#endregion

		#region MembershipUser Constructors

		/// <summary>
		/// Creates a new instance of a System.Web.Security.MembershipUser object for
		///  a class that inherits the System.Web.Security.MembershipUser class.
		/// </summary>
		protected MembershipUserBase()
			: base()
		{
		}

		/// <summary>
		/// Creates a new membership user object with the specified property values.
		/// </summary>
		/// <param name="providerName">The System.Web.Security.MembershipUser.ProviderName string for the membership user.</param>
		/// <param name="name">The System.Web.Security.MembershipUser.UserName string for the membership user.</param>
		/// <param name="providerUserKey">The System.Web.Security.MembershipUser.ProviderUserKey identifier for the membership user.</param>
		/// <param name="email">The System.Web.Security.MembershipUser.Email string for the membership user.</param>
		/// <param name="passwordQuestion">The System.Web.Security.MembershipUser.PasswordQuestion string for the membership user.</param>
		/// <param name="comment">The System.Web.Security.MembershipUser.Comment string for the membership user.</param>
		/// <param name="isApproved">The System.Web.Security.MembershipUser.IsApproved value for the membership user.</param>
		/// <param name="isLockedOut">true to lock out the membership user; otherwise, false.</param>
		/// <param name="creationDate">The System.Web.Security.MembershipUser.CreationDateSystem.DateTime object for the membership user.</param>
		/// <param name="lastLoginDate">The System.Web.Security.MembershipUser.LastLoginDateSystem.DateTime object for the membership user.</param>
		/// <param name="lastActivityDate">The System.Web.Security.MembershipUser.LastActivityDateSystem.DateTime object for the membership user.</param>
		/// <param name="lastPasswordChangedDate">The System.Web.Security.MembershipUser.LastPasswordChangedDateSystem.DateTime object for the membership user.</param>
		/// <param name="lastLockoutDate">The System.Web.Security.MembershipUser.LastLockoutDateSystem.DateTime object for the membership user.</param>
		public MembershipUserBase(string providerName, string name, object providerUserKey, string email, string passwordQuestion, string comment, bool isApproved, bool isLockedOut, DateTime creationDate, DateTime lastLoginDate, DateTime lastActivityDate, DateTime lastPasswordChangedDate, DateTime lastLockoutDate)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}