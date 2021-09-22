# GlucoseNotifications
This app was developed because of my phone being unable to reach a volume to wake me up when my Glucose Sensors triggered an alert of a Low/High Sugar.

GlucoseNotifications uses data submitted from the phone, to a MySQL database (for me using the MacroDroid app) and checks the database for recent entries every X amount of seconds (configurable)

If data is found, a timer is triggered, that when reached can blare an alarm of the users choosing (5 available) using the users computer speakers

It's a niche thing, but it works for me - extremely well.

This app makes heavy use of Webhooks, and requires some PHP Capable web hosting, as well as a MySQL/MariaDB database server (most web hosts include this) to deposit the data.
An index.php file is included for you to upload to your web host that contains the web hooks necessary for this to function properly.

A MacroDroid tutorial is coming soon (For android users) - I don't know if there is an iOS app that can read notifications like is possible on android!
