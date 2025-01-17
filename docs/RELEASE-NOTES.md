# Release Notes

## 7.2.0 - 21 October 2021

Breaking changes:
- (None)

New features:
- Added `DotNetProject.ExcludedItems` property.
- Added `DotNetProject.IncludedItems` property.
- Added `TargetFramework` support for .NET 6.

Bug fixes / internal changes:
- Added default message for `InvalidDotNetProjectException` and `InvalidDotNetSolutionException`.
- Updated package dependency of `ByteDev.Xml` to v2.0.0.

## 7.1.0 - 09 December 2020

Breaking changes:
- (None)

New features:
- Added `TargetFramework.OperatingSystem` for .NET 5 TFM.

Bug fixes / internal changes:
- (None)

## 7.0.0 - 21 September 2020

Breaking changes:
- Renamed `DotNetProjectTarget` to `TargetFramework`.
- Renamed `TargetType` to `TargetFrameworkType`.

New features:
- Added greater target framework moniker support.

Bug fixes / internal changes:
- Fixes to handle more .NET 5 target framework monikers.

## 6.0.1 - 26 July 2020

Breaking changes:
- (None)

New features:
- (None)

Bug fixes / internal changes:
- Package updates.

## 6.0.0 - 13 June 2020

Breaking changes:
- No exception thrown on lack of target framework in project file.

New features:
- (None)

Bug fixes / internal changes:
- Fix so `TargetFramework` for single framework and `TargetFrameworks` for multi-target in project file.
- Various package fixes.

## 5.0.4 - 30 April 2020

Breaking changes:
- (None)

New features:
- (None)

Bug fixes / internal changes:
- Added support for .NET 5 target framework.
- Fixed `DotNetProjectTarget.Version` to always be consistent format.
- Added missing XML doc to public methods.

## 5.0.3 - 19 March 2020

Breaking changes:
- (None)

New features:
- (None)

Bug fixes / internal changes:
- Fix: can now handle solution file with Major Version 16.

## 5.0.2 - 02 March 2020

Breaking changes:
- (None)

New features:
- (None)

Bug fixes:
- Added package dependency on .NET Standard 2.0.

## 5.0.1 - 08 Oct 2019

Breaking changes:
- Extracted `DotNetProject` properties to `AssemblyInfoProperties` and `NugetMetaDataProperties` classes.

New features:
- (None)

Bug fixes:
- Fixed XML documentation as part of packages.

## 4.1.0 - 07 Sep 2019

Breaking changes:
- (None)

New features:
- Added project properties `CopyRight`, `PackageLicenseUrl`, `PackageProjectUrl`, `PackageIconUrl`, `RepositoryUrl`, `RepositoryType`, `PackageReleaseNotes`.
- Improved public method and property comments.

Bug fixes:
- (None)

## 4.0.0 - 22 Aug 2019

Breaking changes:
- `DotNetSolutionProjectTypeFactory` moved to Factories NS

New features:
- Added `DotNetSolutionProject.ProjectSections` property which contains a collection of `DotNetSolutionProjectSection` objects that each represent a Project's `ProjectSection`.

Bug fixes:
- (None)

## 3.2.0 - 10 Aug 2019

Breaking changes:
- (None)

New features:
- Added `DotNetSolution.GlobalSections` property which contains a collection of `DotNetSolutionGlobalSection` objects that each represent a `GlobalSection` in the solution file.

Bug fixes:
- (None)
