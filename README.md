# Web References Smoke
For more details see the [Web References Checklist](https://youtrack.jetbrains.com/articles/RIDER-A-1420/Web-References-Checklist)

---
Repeat for all the projects in the following solution folders:
- ASP.NET
- ASP.NET Core
- Console apps and libs
- Desktop
- Xamarin
### Add Web Reference
Expected: 
- Added web references are displayed in Solution Explorer both with `Show All` enabled and disabled
- Projects with added references could be built successfully
- .NET/.NET Core projects' services have a generated cs file and ConnectedService.json config
- .NET Framework projects' services have a generated cs file and svcmap config
- Web reference couldn't be added to shared projects

### Edit Web Reference
Expected:
- Add Web Reference dialogue is opened
### Update Web Reference
Expected:
- Updating Web Reference progress bar is displayed
- The reference is updated
### Delete Web Reference
Expected:
- Web reference disappears from Solution Explorer
- Generated files are deleted from the file system
### Migrate a solution with web services from VS to Rider
Expected:
- All the web references are picked up by Rider
- Solution could be built 

