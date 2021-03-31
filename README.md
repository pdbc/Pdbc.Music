# Pdbc.Music

Pdbc.Music is a pet project of mine to try out various things.  I tend to find more benefit when developing on a solution that has some weigth than simply setting up basic classes for your test purpose.

Stuff included in PDBC.Music

## T4 - Builder templates 

Domain/Dto classes need to be constructed throughout the lifetime of a project.  I like the approach of T4 templates to 'generate' builder classes to have a fluent interface for constructing the objects.  By generating the builder classes using T4, they are always insync with the actual class.  Renaming/refactoring goes quicker and smoother.

An added benefit is for creating test objects.  I can simply inherit from the generated builder and setup default values for all properties.  Any new property will always be included in all tests leading to a more stable and robust environment.
