ASP.NET-Membership-Base-Classes
===============================

Abstract base classes for System.Web.Security MembershipProvider, MembershipUser &amp; RoleProvider - implements all those useless abstract properties and methods, 
so you can just inhert from this and implement whatever functionality is required.

MembershipProviderBase
------------------

An abstract class implementing the abstract methods and properties of MembershipProvider with NotImplementedExceptions. When defining a custom MembershipProvider, inherit
from this class and override the methods / properties you wish to implement.

Register your implementation in web.config, for example:

``
	<configuration>
		...
		<system.web>
			...
			<membership defaultProvider="MyCustomMembershipProvider">
			<providers>
				<clear />
				<add name="MyCustomMembershipProvider" type="MyAppNamespace.MyCustomMembershipProvider" />
			</providers>
			</membership>
		</system.web>
	</configuration>	
``

It's functionality is not called automatically by ASP.Net MVC, it is accessible via the static methods and properties on System.Web.Security.Membership.

MembershipUserBase
------------------

You do not need to override MembershipUser when creating a custom MembershipProvider - you can simply instantiate a MembershipUser.

This class is useful if you want to explicitly provider NotImplementedExceptions for properties or methods that your custom MembershipProvider does not support.

RoleProviderBase
----------------

An abstract class implementing the abstract methods and properties of RoleProvider with NotImplementedExceptions. When defining a custom RoleProvider, inherit
from this class and override the methods / properties you wish to implement.

Register your implementation in web.config, for example:

``
	<configuration>
		...
		<system.web>
			...
			<roleManager enabled="true" defaultProvider="MyCustomRoleProvider">
				<providers>
					<clear />
					<add name="MyCustomRoleProvider" type="MyAppNamespace.MyCustomRoleProvider" />
				</providers>
			</roleManager>
		</system.web>
	</configuration>	
```

Once registered, it is accessible through the static methods and properties on System.Web.Security.Roles.

When using Forms Authentication with ASP.NET MVC, calls to `HttpContext.User.IsInRole(...)` are implemented by calling the `GetRolesForUser(string username)` method of the 
registered RoleProvider. This is used when checking roles with the `[Authorize(Roles="ROLE_NAME")]` attribute in ASP.NET MVC.

Other properties / methods on the RoleProvider are not called automatically via ASP.NET MVC.
