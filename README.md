# Automatic Irrigation System - WEB (AIS-WEB)

## Description AIS
Automatic Irrigation System is a automatic system that measure soil moisture with a sensor and decides if it need water or not.
The system then register this data to a open rest API (AIS-API) and a WEB based system gets this data and output it on a webpage (AIS-WEB).

The final goal with this project is that you can have a lots of fresh plants and flowers without have to spend time of to managing them.

## Description AIS-WEB
AIS WEB is a website that gives you control off all sensors and the information your sensors outputs to the API (AIS-API).
This is also the place where you can add, remove or edit plants that is added to your system.

# BETA
This version is fully functional but i recommend to use it in privat network becuse there is no built in securite.  

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

## Installation
1. Download and setup repo: [AIS-API](https://github.com/joakimremler/AIS-API)

2. Download repo: [AIS-WEB](https://github.com/joakimremler/AIS-WEB)

3. Start AIS-API.

4. You're done, enjoy!

## Resources
Tutorial on MVC project that connects to a API:
[MVC connect to API](https://www.youtube.com/watch?v=P8QtHXmCpCc)
