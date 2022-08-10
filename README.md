# LearnEntityFramework
Practice Init & Update database using Code first method

# Techstack
1. C#
2. EF Core 6
3. SQL Server

# Create Database
1. Create Model
2. Update model & relationship in `LibraryContext` class
3. Run command `Add-Migration "Migration-Name"` ex:Add-Migration AddCategoryTable
4. Run Update-Database -verbose

# If you want Seed Data
1. Write code into `LibraryContext`
2. Run `Add-Migration "Migration-Name"`
3. Run `Update-Database -verbose`

# If you want Revert migration
1. run `Update-Database "Your_Good_Migration_You_Want_To_Revert_To"` (can find in table [__EFMigrationsHistory] in SQLSerer)
![image](https://user-images.githubusercontent.com/12756406/183879794-e2017b68-9ab3-400f-878a-5acf755ba8ae.png)
2. run `Remove-Migration` (this command will delete class Migration related)
