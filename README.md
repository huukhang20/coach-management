# Coach Management

## Setup
In CoachManagement folder, create `appsettings.json` with your database's username and password:
```
{
  "ConnectionStrings": {
    "CoachManagement": "Server=(local);uid=your-username;pwd=your-password;database=CoachManagement;TrustServerCertificate=true"
  }
}
```
Make sure `CoachManagement.csproj` has the following lines:
```
<ItemGroup>
  <None Update="appsettings.json">
    <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
  </None>
</ItemGroup>
```
