// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.V2
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Groups.
    /// </summary>
    public static partial class GroupsExtensions
    {
            /// <summary>
            /// Returns a list of workspaces the user has access to.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Group.Read.All or Group.ReadWrite.All or
            /// Workspace.Read.All or Workspace.ReadWrite.All&lt;br/&gt;To set the
            /// permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='filter'>
            /// Filters the results, based on a boolean condition
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results
            /// </param>
            public static ODataResponseListGroup GetGroups(this IGroups operations, string filter = default(string), int? top = default(int?), int? skip = default(int?))
            {
                return operations.GetGroupsAsync(filter, top, skip).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of workspaces the user has access to.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Group.Read.All or Group.ReadWrite.All or
            /// Workspace.Read.All or Workspace.ReadWrite.All&lt;br/&gt;To set the
            /// permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='filter'>
            /// Filters the results, based on a boolean condition
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataResponseListGroup> GetGroupsAsync(this IGroups operations, string filter = default(string), int? top = default(int?), int? skip = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetGroupsWithHttpMessagesAsync(filter, top, skip, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates new workspace.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Group.Read.All or Group.ReadWrite.All or
            /// Workspace.Read.All or Workspace.ReadWrite.All&lt;br/&gt;To set the
            /// permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='requestParameters'>
            /// Create group request parameters
            /// </param>
            public static Group CreateGroup(this IGroups operations, GroupCreationRequest requestParameters)
            {
                return operations.CreateGroupAsync(requestParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates new workspace.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Group.Read.All or Group.ReadWrite.All or
            /// Workspace.Read.All or Workspace.ReadWrite.All&lt;br/&gt;To set the
            /// permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='requestParameters'>
            /// Create group request parameters
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Group> CreateGroupAsync(this IGroups operations, GroupCreationRequest requestParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateGroupWithHttpMessagesAsync(requestParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified workspace.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Group.Read.All or Group.ReadWrite.All or
            /// Workspace.Read.All or Workspace.ReadWrite.All&lt;br/&gt;To set the
            /// permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The workspace id to delete
            /// </param>
            public static object DeleteGroup(this IGroups operations, string groupId)
            {
                return operations.DeleteGroupAsync(groupId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified workspace.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Group.Read.All or Group.ReadWrite.All or
            /// Workspace.Read.All or Workspace.ReadWrite.All&lt;br/&gt;To set the
            /// permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The workspace id to delete
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> DeleteGroupAsync(this IGroups operations, string groupId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteGroupWithHttpMessagesAsync(groupId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of users that have access to the specified workspace.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Group.Read.All or Group.ReadWrite.All or
            /// Workspace.Read.All or Workspace.ReadWrite.All&lt;br/&gt;To set the
            /// permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The workspace id
            /// </param>
            public static ODataResponseListGroupUserAccessRight GetGroupUsers(this IGroups operations, string groupId)
            {
                return operations.GetGroupUsersAsync(groupId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of users that have access to the specified workspace.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Group.Read.All or Group.ReadWrite.All or
            /// Workspace.Read.All or Workspace.ReadWrite.All&lt;br/&gt;To set the
            /// permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The workspace id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataResponseListGroupUserAccessRight> GetGroupUsersAsync(this IGroups operations, string groupId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetGroupUsersWithHttpMessagesAsync(groupId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Grants the specified user permissions to the specified workspace.
            /// </summary>
            /// <remarks>
            /// **Note**: Only Admin access right is supported.
            /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Group.Read.All or
            /// Group.ReadWrite.All or Workspace.Read.All or
            /// Workspace.ReadWrite.All&lt;br/&gt;To set the permissions scope, see
            /// [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The workspace id
            /// </param>
            /// <param name='userDetails'>
            /// Details of user access right
            /// </param>
            public static object AddGroupUser(this IGroups operations, string groupId, GroupUserAccessRight userDetails)
            {
                return operations.AddGroupUserAsync(groupId, userDetails).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Grants the specified user permissions to the specified workspace.
            /// </summary>
            /// <remarks>
            /// **Note**: Only Admin access right is supported.
            /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Group.Read.All or
            /// Group.ReadWrite.All or Workspace.Read.All or
            /// Workspace.ReadWrite.All&lt;br/&gt;To set the permissions scope, see
            /// [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The workspace id
            /// </param>
            /// <param name='userDetails'>
            /// Details of user access right
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> AddGroupUserAsync(this IGroups operations, string groupId, GroupUserAccessRight userDetails, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddGroupUserWithHttpMessagesAsync(groupId, userDetails, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified user permissions from the specified workspace.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Group.Read.All or Group.ReadWrite.All or
            /// Workspace.Read.All or Workspace.ReadWrite.All&lt;br/&gt;To set the
            /// permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The workspace id
            /// </param>
            /// <param name='user'>
            /// The email adress of the user to delete
            /// </param>
            public static object DeleteUserInGroup(this IGroups operations, string groupId, string user)
            {
                return operations.DeleteUserInGroupAsync(groupId, user).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified user permissions from the specified workspace.
            /// </summary>
            /// <remarks>
            /// &lt;br/&gt;**Required scope**: Group.Read.All or Group.ReadWrite.All or
            /// Workspace.Read.All or Workspace.ReadWrite.All&lt;br/&gt;To set the
            /// permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The workspace id
            /// </param>
            /// <param name='user'>
            /// The email adress of the user to delete
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> DeleteUserInGroupAsync(this IGroups operations, string groupId, string user, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteUserInGroupWithHttpMessagesAsync(groupId, user, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Assigns **"My Workspace"** to the specified capacity.
            /// </summary>
            /// <remarks>
            /// **Note**: To perform this operation, the user must have admin or assign
            /// permissions on the capacity. To unassign **"My Workspace"** from a
            /// capacity, Empty Guid (00000000-0000-0000-0000-000000000000) should be
            /// provided as capacityId.  &lt;br/&gt;&lt;br/&gt;**Required scope**:
            /// Capacity.ReadWrite.All and Workspace.ReadWrite.All. &lt;br/&gt;To set the
            /// permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='requestParameters'>
            /// Assign to capacity parameters
            /// </param>
            public static object AssignMyWorkspaceToCapacity(this IGroups operations, AssignToCapacityRequest requestParameters)
            {
                return operations.AssignMyWorkspaceToCapacityAsync(requestParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Assigns **"My Workspace"** to the specified capacity.
            /// </summary>
            /// <remarks>
            /// **Note**: To perform this operation, the user must have admin or assign
            /// permissions on the capacity. To unassign **"My Workspace"** from a
            /// capacity, Empty Guid (00000000-0000-0000-0000-000000000000) should be
            /// provided as capacityId.  &lt;br/&gt;&lt;br/&gt;**Required scope**:
            /// Capacity.ReadWrite.All and Workspace.ReadWrite.All. &lt;br/&gt;To set the
            /// permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='requestParameters'>
            /// Assign to capacity parameters
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> AssignMyWorkspaceToCapacityAsync(this IGroups operations, AssignToCapacityRequest requestParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AssignMyWorkspaceToCapacityWithHttpMessagesAsync(requestParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Assigns the specified workspace to the specified capacity.
            /// </summary>
            /// <remarks>
            /// **Note**: To perform this operation, the user must be admin on the
            /// specified workspace and have admin or assign permissions on the capacity.
            /// To unassign the specified workspace from a capacity, Empty Guid
            /// (00000000-0000-0000-0000-000000000000) should be provided as capacityId.
            /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Capacity.ReadWrite.All and
            /// Workspace.ReadWrite.All. &lt;br/&gt;To set the permissions scope, see
            /// [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The workspace id
            /// </param>
            /// <param name='requestParameters'>
            /// Assign to capacity parameters
            /// </param>
            public static object AssignToCapacity(this IGroups operations, string groupId, AssignToCapacityRequest requestParameters)
            {
                return operations.AssignToCapacityAsync(groupId, requestParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Assigns the specified workspace to the specified capacity.
            /// </summary>
            /// <remarks>
            /// **Note**: To perform this operation, the user must be admin on the
            /// specified workspace and have admin or assign permissions on the capacity.
            /// To unassign the specified workspace from a capacity, Empty Guid
            /// (00000000-0000-0000-0000-000000000000) should be provided as capacityId.
            /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Capacity.ReadWrite.All and
            /// Workspace.ReadWrite.All. &lt;br/&gt;To set the permissions scope, see
            /// [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The workspace id
            /// </param>
            /// <param name='requestParameters'>
            /// Assign to capacity parameters
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> AssignToCapacityAsync(this IGroups operations, string groupId, AssignToCapacityRequest requestParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AssignToCapacityWithHttpMessagesAsync(groupId, requestParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of workspaces for the organization.
            /// </summary>
            /// <remarks>
            /// **Note:** The user must have administrator rights (such as Office 365
            /// Global Administrator or Power BI Service Administrator) to call this API.
            /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Tenant.Read.All or
            /// Tenant.ReadWrite.All&lt;br/&gt;Application only and delegated permissions
            /// are supported.&lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline
            /// </param>
            /// <param name='filter'>
            /// Filters the results based on a boolean condition
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results
            /// </param>
            public static ODataResponseListGroup GetGroupsAsAdmin(this IGroups operations, string expand = default(string), string filter = default(string), int? top = default(int?), int? skip = default(int?))
            {
                return operations.GetGroupsAsAdminAsync(expand, filter, top, skip).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of workspaces for the organization.
            /// </summary>
            /// <remarks>
            /// **Note:** The user must have administrator rights (such as Office 365
            /// Global Administrator or Power BI Service Administrator) to call this API.
            /// &lt;br/&gt;&lt;br/&gt;**Required scope**: Tenant.Read.All or
            /// Tenant.ReadWrite.All&lt;br/&gt;Application only and delegated permissions
            /// are supported.&lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline
            /// </param>
            /// <param name='filter'>
            /// Filters the results based on a boolean condition
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataResponseListGroup> GetGroupsAsAdminAsync(this IGroups operations, string expand = default(string), string filter = default(string), int? top = default(int?), int? skip = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetGroupsAsAdminWithHttpMessagesAsync(expand, filter, top, skip, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates the specified workspace properties.
            /// </summary>
            /// <remarks>
            /// **Note**: This API is currently limited to updating workspaces in the new
            /// workspace experiences preview. Only name and description can be updated,
            /// and name must be unique inside an organization. The user must have
            /// administrator rights (such as Office 365 Global Administrator or Power BI
            /// Service Administrator) to call this API. &lt;br/&gt;&lt;br/&gt;**Required
            /// scope**: Tenant.ReadWrite.All&lt;br/&gt;Application only and delegated
            /// permissions are supported.&lt;br/&gt;To set the permissions scope, see
            /// [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The workspace id
            /// </param>
            /// <param name='groupProperties'>
            /// The properties to update
            /// </param>
            public static object UpdateGroupAsAdmin(this IGroups operations, string groupId, Group groupProperties)
            {
                return operations.UpdateGroupAsAdminAsync(groupId, groupProperties).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates the specified workspace properties.
            /// </summary>
            /// <remarks>
            /// **Note**: This API is currently limited to updating workspaces in the new
            /// workspace experiences preview. Only name and description can be updated,
            /// and name must be unique inside an organization. The user must have
            /// administrator rights (such as Office 365 Global Administrator or Power BI
            /// Service Administrator) to call this API. &lt;br/&gt;&lt;br/&gt;**Required
            /// scope**: Tenant.ReadWrite.All&lt;br/&gt;Application only and delegated
            /// permissions are supported.&lt;br/&gt;To set the permissions scope, see
            /// [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The workspace id
            /// </param>
            /// <param name='groupProperties'>
            /// The properties to update
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> UpdateGroupAsAdminAsync(this IGroups operations, string groupId, Group groupProperties, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateGroupAsAdminWithHttpMessagesAsync(groupId, groupProperties, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Grants user permissions to the specified workspace.
            /// </summary>
            /// <remarks>
            /// **Note:** The user must have administrator rights (such as Office 365
            /// Global Administrator or Power BI Service Administrator) to call this API.
            /// &lt;br/&gt;&lt;br/&gt;**Required scope**:
            /// Tenant.ReadWrite.All&lt;br/&gt;Application only and delegated permissions
            /// are supported.&lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The workspace id
            /// </param>
            /// <param name='userDetails'>
            /// Details of user access right
            /// </param>
            public static object AddUserAsAdmin(this IGroups operations, string groupId, GroupUserAccessRight userDetails)
            {
                return operations.AddUserAsAdminAsync(groupId, userDetails).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Grants user permissions to the specified workspace.
            /// </summary>
            /// <remarks>
            /// **Note:** The user must have administrator rights (such as Office 365
            /// Global Administrator or Power BI Service Administrator) to call this API.
            /// &lt;br/&gt;&lt;br/&gt;**Required scope**:
            /// Tenant.ReadWrite.All&lt;br/&gt;Application only and delegated permissions
            /// are supported.&lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The workspace id
            /// </param>
            /// <param name='userDetails'>
            /// Details of user access right
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> AddUserAsAdminAsync(this IGroups operations, string groupId, GroupUserAccessRight userDetails, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddUserAsAdminWithHttpMessagesAsync(groupId, userDetails, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Removes user permissions to the specified workspace.
            /// </summary>
            /// <remarks>
            /// **Note:** The user must have administrator rights (such as Office 365
            /// Global Administrator or Power BI Service Administrator) to call this API.
            /// &lt;br/&gt;&lt;br/&gt;**Required scope**:
            /// Tenant.ReadWrite.All&lt;br/&gt;Application only and delegated permissions
            /// are supported.&lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The workspace id
            /// </param>
            /// <param name='user'>
            /// The user principal name (UPN) of the user to remove (usually the user's
            /// email)
            /// </param>
            public static object DeleteUserAsAdmin(this IGroups operations, string groupId, string user)
            {
                return operations.DeleteUserAsAdminAsync(groupId, user).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Removes user permissions to the specified workspace.
            /// </summary>
            /// <remarks>
            /// **Note:** The user must have administrator rights (such as Office 365
            /// Global Administrator or Power BI Service Administrator) to call this API.
            /// &lt;br/&gt;&lt;br/&gt;**Required scope**:
            /// Tenant.ReadWrite.All&lt;br/&gt;Application only and delegated permissions
            /// are supported.&lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The workspace id
            /// </param>
            /// <param name='user'>
            /// The user principal name (UPN) of the user to remove (usually the user's
            /// email)
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> DeleteUserAsAdminAsync(this IGroups operations, string groupId, string user, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteUserAsAdminWithHttpMessagesAsync(groupId, user, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Restores a deleted workspace.
            /// </summary>
            /// <remarks>
            /// **Note**: This API is currently limited to restoring workspaces in the new
            /// workspace experiences preview. The user must have administrator rights
            /// (such as Office 365 Global Administrator or Power BI Service Administrator)
            /// to call this API. &lt;br/&gt;&lt;br/&gt;**Required scope**:
            /// Tenant.ReadWrite.All&lt;br/&gt;Application only and delegated permissions
            /// are supported.&lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The workspace id
            /// </param>
            /// <param name='groupRestoreRequest'>
            /// Details of the group restore request
            /// </param>
            public static object RestoreDeletedGroupAsAdmin(this IGroups operations, string groupId, GroupRestoreRequest groupRestoreRequest)
            {
                return operations.RestoreDeletedGroupAsAdminAsync(groupId, groupRestoreRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Restores a deleted workspace.
            /// </summary>
            /// <remarks>
            /// **Note**: This API is currently limited to restoring workspaces in the new
            /// workspace experiences preview. The user must have administrator rights
            /// (such as Office 365 Global Administrator or Power BI Service Administrator)
            /// to call this API. &lt;br/&gt;&lt;br/&gt;**Required scope**:
            /// Tenant.ReadWrite.All&lt;br/&gt;Application only and delegated permissions
            /// are supported.&lt;br/&gt;To set the permissions scope, see [Register an
            /// app](https://docs.microsoft.com/power-bi/developer/register-app).
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='groupId'>
            /// The workspace id
            /// </param>
            /// <param name='groupRestoreRequest'>
            /// Details of the group restore request
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> RestoreDeletedGroupAsAdminAsync(this IGroups operations, string groupId, GroupRestoreRequest groupRestoreRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RestoreDeletedGroupAsAdminWithHttpMessagesAsync(groupId, groupRestoreRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
