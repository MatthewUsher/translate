# Welcome to Tradurre

[![Main Commit Queue](https://github.com/MatthewUsher/translate/actions/workflows/build.yml/badge.svg?branch=main)](https://github.com/MatthewUsher/translate/actions/workflows/build.yml)

## What is Tradurre?

Tradurre, an Italian word, means to translate. Tradurre is a library and application that includes everything necessary to migrate SQL scripts from one database to another. The project has a single goal, to simplify the migration between platforms as painlessly as possible.

While the conversion of SQL from one language to another is important, it is often the first area of investigation in a migration project. Taking weeks to convert the database portion of your application for simple platform validation should take hours, not weeks or months. Tradurre is positioned to help with that initial investigation to allow you to make a platform choice. Tradurre can then be used to do a production SQL code translation during your application migration project.

## Getting Started

We are just starting this project as of June 2025. Contribution details will follow shortly.

## Contributing

We encourage you to contribute to Tradurre! Details on how to contribute suggestions, feedback, samples, and code will be coming soon. 


## Architecture
To translate SQL dialects properly, we use an Antlr based parser path for each source language. The source language is placed into an intermediate SQL language object model that is then passed to a writer for the conversion to that flavor of SQL. 

## Why not...

### Copy and Replace

Context is important in SQL. A keyword could be a command if encapsulated correctly so copying and pasting doesn't take into the location of the word to deduce it's meaning. While copy and replace can be effective, it is error prone and can return in exact results causing you to spend more time debugging the change in your application code.

### Regular Expressions

For the same reasons that Copy and Paste don't work, neither do Regular Expresssions. Context is really important and being accurate with the translation is critical. 



## License

Tradurre is released under the [GNU General Public License version 3](https://opensource.org/license/gpl-3-0).
