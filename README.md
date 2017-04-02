# Automatic Irrigation System - WEB (AIS-WEB)

## Description AIS
Automatic Irrigation System is a automatic system that measure soil moisture with a sensor and decides if it need water or not.
The system then register this data to a open rest API (AIS-API) and a WEB based system gets this data and output it on a webpage (AIS-WEB).

The final goal with this project is that you can have a lots of fresh plants and flowers without have to spend time of to managing them.

## Description AIS-WEB
AIS WEB is a website that gives you control off all sensors and the information your sensors outputs to the API (AIS-API).
This is also the place where you can add, remove or edit plants that is added to your system.

# BETA
This version is fully functional but i recommend to use it in privat network becuse there is no securite built in.  

## TODO
* Add security to the webpage that you can only POST, DELETE or PUT values to sensors that is connected to you.
* Login
* Add multiply users

## Languages
This project is written in C#

## Features
* Easy to manages.
* Outputs data from sensors.
* Add, edit and Delete values.
* Connected to a REST API.
* Updates API with new information.


## Tested software versions
* Mysql Workbench 6.3.8
* Microsoft Visual Studio Professional 2017
* Microsoft Visual Studio Community 2015

## Recommended software versions
* Mysql Workbench 6.3.8
* Microsoft Visual Studio Professional 2017

## Installation (WRITE THIS!!!!!)
1. Clone this repo and set folder Linkify to localhost or create a [Virtual directory](https://en.wikipedia.org/wiki/Virtual_directory)
  `git clone git@github.com:joakimremler/Linkify.git`.

2. Create a Database in Mysql called Linkify `CREATE DATABASE Linkify;`.

3. Import `linkify.sql` MySql backup file. Navigate to assets/mysql and insert this line:

    `mysql -u root -p Linkify < linkify.sql`

4. Edit your settings in core/init.php.

5. You're done, enjoy!

## Resources
Tutorial on MVC project that connects to a API:
[MVC connect to API](https://www.youtube.com/watch?v=P8QtHXmCpCc)
