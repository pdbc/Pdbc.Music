# Pdbc.Music

Pdbc.Music is a pet project of mine to try out various things.  I tend to find more benefit when developing on a solution that has some weigth than simply setting up basic classes for your test purpose.  

Stuff included in PDBC.Music contains the following topics

## The PDBC.Music Domain

The domain I have chosen here is a simple music database.  I have a lot of music that over time gets copied and over again, new songs are added, songs are duplicated.  So the first intent of the project was to organize my music files, find duplicated files and remove these.  Verify the mp3 tags on the file and correct them.  And additionaly allow the directory and file structure to be uniform wich clear naming conventions.

The model is fairly simple.  We have a song object that has an Artist (with a name property) who is the performer of the song and a Genre (with a name property) that holds the type of the song.  The song also has FileInformation (where is it stored on the file system) and can be included/excluded in various play lists.

## Architecture & Components

PDBC.Music has an Entity Framework Core data layer exposed with the repository pattern.  A Core layer will use this data for all manipulation actions and expose its data by a WebApi.  All code is written in .NET 5.0.  The core layer relies on Mediatr to expose a CQRS style pipeline for uniform development mechanism.

It is by no means whatsover a reference architecture, but I feel that splitting up my classes and projects in this way has helped me maintain and code better and increased my productivity.

## T4 - Builder templates 

Domain/Dto classes need to be constructed throughout the lifetime of a project.  I like the approach of T4 templates to 'generate' builder classes to have a fluent interface for constructing the objects.  By generating the builder classes using T4, they are always insync with the actual class.  Renaming/refactoring goes quicker and smoother.

An added benefit is for creating test objects.  I can simply inherit from the generated builder and setup default values for all properties.  Any new property will always be included in all tests leading to a more stable and robust environment.
