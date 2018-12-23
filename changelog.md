# Changelog #
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/).

## [2.0.0] - 2018-12-23 ##
### Added ###
- Added `<see langword="xxxx" />` support.
- Added information about source file(s) in the header of type and type members documentation.
- Added information (and link if available) about overriden Method, Property or Event.
- Added information (and link if available) about implemented interface Method, Property or Event.
- Added information about directly derived types (Derived: ...). Note: only the types existing in project being documented are displayed here.
- Added information about types implementing the interface (Implemented by: ...). Note: only the types existing in project being documented are displayed here.
- Added information about Explicit Interface Implementations (section in a type page). Note: explicit interface implementation members are listed both in the event/propery/method table as well as in Explicit Interface Implementations table.
- Added `<inheritdoc />` support.
- Added Output generator add-ons functionality.

### Changed ###
- XML Documentation parsing error is not a blocker anymore, the warning is displayed in console.
- Improved exception presentation within console.

### Fixed ###
- [Issue #1](https://github.com/adamecr/MarkupDoc/issues/1): Method title shown correctly (there has been a constant "Title" instead of variable `title` used). 

 
### Deprecated ###
- MarkupGenerator.WritePageFooter has been replaced by MarkupGenerator.WritePageFooterAsync. The functionality remains the same, just the name of the method has been corrected. WritePageFooter will be removed in version 3.x.x.
- MarkupGenerator.Split has been replaced by MarkupGenerator.SplitAsync. The functionality remains the same, just the name of the method has been corrected. Split will be removed in version 3.x.x.

### Breaking changes ###
- IMarkupProvider has been extended with `public string Extension` property.

## [1.0.0] - 2018-12-02 ##
### Added ###
- Initial release

[2.0.0]: https://github.com/adamecr/MarkupDoc/compare/v1.0.0...v2.0.0
[1.0.0]: https://github.com/adamecr/MarkupDoc/releases/tag/v1.0.0
