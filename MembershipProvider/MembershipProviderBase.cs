using System;
using System.Web.Security;

namespace MembershipBase
{

	/// <summary>
	/// A base class which implements NotImplementedExceptions for the properties 
	/// and methods that are marked as abstract in MembershipProvider.
	/// </summary>
	internal abstract class MembershipProviderBase : MembershipProvider
	{

		#region MembershipProvider Abstract Properties

		/// <summary>
		/// The name of the application using the custom membership provider.
		/// </summary>
		public override string ApplicationName
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		/// Indicates whether the membership provider is configured to allow 
		/// users to reset their passwords.
		/// </summary>
		public override bool EnablePasswordReset
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		/// Indicates whether the membership provider is configured to allow 
		/// users to retrieve their passwords.
		/// </summary>
		public override bool EnablePasswordRetrieval
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		/// Gets the number of invalid password or password-answer attempts allowed 
		/// before the membership user is locked out.
		/// </summary>
		public override int MaxInvalidPasswordAttempts
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		/// Gets the minimum number of special characters that must be
		/// present in a valid password.
		/// </summary>
		public override int MinRequiredNonAlphanumericCharacters
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		/// Gets the minimum length required for a password.
		/// </summary>
		public override int MinRequiredPasswordLength
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		/// Gets the number of minutes in which a maximum number of invalid password or 
		/// password-answer attempts are allowed before the membership user is locked out.
		/// </summary>
		public override int PasswordAttemptWindow
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		/// Gets a value indicating the format for storing passwords in the membership data store.
		/// </summary>
		public override MembershipPasswordFormat PasswordFormat
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		/// Gets the regular expression used to evaluate a password.
		/// </summary>
		public override string PasswordStrengthRegularExpression
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		/// Gets a value indicating whether the membership provider is configured to require the 
		/// user to answer a password question for password reset and retrieval.
		/// </summary>
		public override bool RequiresQuestionAndAnswer
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>
		/// Gets a value indicating whether the membership provider is configured 
		/// to require a unique e-mail address for each user name.
		/// </summary>
		public override bool RequiresUniqueEmail
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		#endregion

		#region MembershipProvider Abstract Methods

		/// <summary>
		/// Processes a request to update the password for a membership user.
		/// </summary>
		/// <param name="username">The user to update the password for.</param>
		/// <param name="oldPassword">The current password for the specified user.</param>
		/// <param name="newPassword">The new password for the specified user.</param>
		/// <returns>true if the password was updated successfully; otherwise, false.</returns>
		public override bool ChangePassword(string username, string oldPassword, string newPassword)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Processes a request to update the password question and answer for a membership user.
		/// </summary>
		/// <param name="username">The user to change the password question and answer for.</param>
		/// <param name="password">The password for the specified user.</param>
		/// <param name="newPasswordQuestion">The new password question for the specified user.</param>
		/// <param name="newPasswordAnswer">The new password answer for the specified user.</param>
		/// <returns>true if the password question and answer are updated successfully; otherwise, false.</returns>
		public override bool ChangePasswordQuestionAndAnswer(string username, string password, string newPasswordQuestion, string newPasswordAnswer)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Adds a new membership user to the data source.
		/// </summary>
		/// <param name="username">The user name for the new user.</param>
		/// <param name="password">The password for the new user.</param>
		/// <param name="email">The e-mail address for the new user.</param>
		/// <param name="passwordQuestion">The password question for the new user.</param>
		/// <param name="passwordAnswer">The password answer for the new user.</param>
		/// <param name="isApproved">Whether or not the new user is approved to be validated.</param>
		/// <param name="providerUserKey">The unique identifier from the membership data source for the user.</param>
		/// <param name="status">A MembershipCreateStatus enumeration value indicating whether the user was created successfully</param>
		/// <returns>A MembershipUser object populated with the information for the newly created user.</returns>
		public override MembershipUser CreateUser(string username, string password, string email, string passwordQuestion, string passwordAnswer, bool isApproved, Object providerUserKey, out MembershipCreateStatus status)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Removes a user from the membership data source.
		/// </summary>
		/// <param name="username">The name of the user to delete.</param>
		/// <param name="deleteAllRelatedData">true to delete data related to the user from the database; false to leave data related to the user in the database.</param>
		/// <returns>true if the user was successfully deleted; otherwise, false.</returns>
		public override bool DeleteUser(string username, bool deleteAllRelatedData)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Gets a collection of membership users where the e-mail address contains the specified e-mail address to match.
		/// </summary>
		/// <param name="emailToMatch">The e-mail address to search for.</param>
		/// <param name="pageIndex">The index of the page of results to return. pageIndex is zero-based.</param>
		/// <param name="pageSize">The size of the page of results to return.</param>
		/// <param name="totalRecords">The total number of matched users.</param>
		/// <returns>A MembershipUserCollection collection that contains a page of pageSizeMembershipUser objects beginning at the page specified by pageIndex.</returns>
		public override MembershipUserCollection FindUsersByEmail(string emailToMatch, int pageIndex, int pageSize, out int totalRecords)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Gets a collection of membership users where the user name contains the specified user name to match.
		/// </summary>
		/// <param name="usernameToMatch">The user name to search for.</param>
		/// <param name="pageIndex">The index of the page of results to return. pageIndex is zero-based.</param>
		/// <param name="pageSize">The size of the page of results to return.</param>
		/// <param name="totalRecords">The total number of matched users.</param>
		/// <returns>A MembershipUserCollection collection that contains a page of pageSizeMembershipUser objects beginning at the page specified by pageIndex.</returns>
		public override MembershipUserCollection FindUsersByName(string usernameToMatch, int pageIndex, int pageSize, out int totalRecords)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Gets a collection of all the users in the data source in pages of data.
		/// </summary>
		/// <param name="pageIndex">The index of the page of results to return. pageIndex is zero-based.</param>
		/// <param name="pageSize">The size of the page of results to return.</param>
		/// <param name="totalRecords">The total number of matched users.</param>
		/// <returns>A MembershipUserCollection collection that contains a page of pageSizeMembershipUser objects beginning at the page specified by pageIndex.</returns>
		public override MembershipUserCollection GetAllUsers(int pageIndex, int pageSize, out int totalRecords)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Gets the number of users currently accessing the application.
		/// </summary>
		/// <returns>
		/// Returns an integer value that is the count of all the users in the data source where the 
		/// LastActivityDate is greater than the current date and time minus the UserIsOnlineTimeWindow. The 
		/// UserIsOnlineTimeWindow is a positive integer value specifying the number of minutes to use when 
		/// determining whether a user is online.
		/// </returns>
		public override int GetNumberOfUsersOnline()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Gets the password for the specified user name from the data source.
		/// </summary>
		/// <param name="username">The user to retrieve the password for.</param>
		/// <param name="answer">The password answer for the user.</param>
		/// <returns>The password for the specified user name.</returns>
		public override string GetPassword(string username, string answer)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Gets user information from the data source based on the unique identifier for the membership user. 
		/// Provides an option to update the last-activity date/time stamp for the user.
		/// </summary>
		/// <param name="providerUserKey">The unique identifier for the membership user to get information for.</param>
		/// <param name="userIsOnline">
		/// true to update the last-activity date/time stamp for the user; false to return 
		/// user information without updating the last-activity date/time stamp for the user.
		/// </param>
		/// <returns>A MembershipUser object populated with the specified user's information from the data source.</returns>
		public override MembershipUser GetUser(Object providerUserKey, bool userIsOnline)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Gets information from the data source for a user. Provides an option to update the last-activity date/time stamp for the user.
		/// </summary>
		/// <param name="username">The name of the user to get information for.</param>
		/// <param name="userIsOnline">
		/// true to update the last-activity date/time stamp for the user; false to return user 
		/// information without updating the last-activity date/time stamp for the user.
		/// </param>
		/// <returns>A MembershipUser object populated with the specified user's information from the data source.</returns>
		public override MembershipUser GetUser(string username, bool userIsOnline)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Gets the user name associated with the specified e-mail address.
		/// </summary>
		/// <param name="email">The e-mail address to search for.</param>
		/// <returns>The user name associated with the specified e-mail address. If no match is found, return null.</returns>
		public override string GetUserNameByEmail(string email)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Resets a user's password to a new, automatically generated password.
		/// </summary>
		/// <param name="username">The user to reset the password for.</param>
		/// <param name="answer">The password answer for the specified user.</param>
		/// <returns>The new password for the specified user.</returns>
		public override string ResetPassword(string username, string answer)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Clears a lock so that the membership user can be validated.
		/// </summary>
		/// <param name="userName">The membership user whose lock status you want to clear.</param>
		/// <returns>true if the membership user was successfully unlocked; otherwise, false.</returns>
		public override bool UnlockUser(string userName)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Updates information about a user in the data source.
		/// </summary>
		/// <param name="user">A MembershipUser object that represents the user to update and the updated information for the user.</param>
		public override void UpdateUser(MembershipUser user)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Verifies that the specified user name and password exist in the data source.
		/// </summary>
		/// <param name="username">The name of the user to validate.</param>
		/// <param name="password">The password for the specified user.</param>
		/// <returns>true if the specified username and password are valid; otherwise, false.</returns>
		public override bool ValidateUser(string username, string password)
		{
			throw new NotImplementedException();
		}

		#endregion

	}
}
