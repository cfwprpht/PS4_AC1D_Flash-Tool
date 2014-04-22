PS4 AC1D Flash Manager
(c) cfwprpht [Free to use for Every One !!]


What it is?
-----------
This is a Tool to handle the PS4 Macronix NOR Flash. It can Read/Write the Chip with use of Teensy++ 2.0
USB Dev Board. But there for the Tool is more only a GUI cause it use @Judges SPIWay.py script for the
Read/Write part.
Then the Tool can validate a PS4 NOR Dump and Display the infos of your Console in the GUI. If you want
you can also store your console infos in a database text file. 
It comes with the Python 2.7 and Python Serial Installer and will check if you have both installed or not.
But at least it hase a own extracter and can extract a PS4 NOR Dump file as well a SLB2 Container.
The validator Routine isn't perfekt right now and even give me on my own dump on 3 of 33 Arrays to check
a false negative. This is mostly to do that there need to be done more investigation on Console specific
Marks and such they are present on all Consoles.
But right now there isn't much use for the end user so i still have time to correct that. In case of your
a Dev and want to write a Dump to your consoles flash that do not validate, then just create a empty txt 
file with the name "developer.conf". This will enable the Tool to activate all blocked buttons.


Used Lib's:
-----------
ConsoleControle.dll -                        is a librarie from Dave Kerr
ProcessInterface.dll -                       is a librarie from Dave Kerr
SPIway.py -                                  is a script from Judges
Log.dll -                                    is a librarie from me (cfwprophet)
Tools.dll -                                  is a librarie from me (cfwprophet)
nor4ps.dll -                                 is a librarie from me (cfwprophet)
SLB2.dll -                                   is a librarie from me (cfwprophet)




So you may ask for what the SPIway.bat will be ?
------------------------------------------------
It's simpli. VisualStudio can't handle the python script. For that a python integration to Visual Studio 
will be needed. There are allready projects for that but in a beta phase. So we use the .batch to kind
 of spoof the python script. In case VS understand and can handle .bat's we just do the same within the .bat
 what we otherwise would do with the python script in VS. We do a "Call" and execute the python script
  with the needed arguments.
  
  
What to do?
-----------
Adjust the validator Routine for the PS4 NOR flash.
Include a Flash Patcher Routine.
(Or) Activate diff Write. (which is allready included into judges SPIway.py script).
Finish the vdump function which will verify the dumped data against the data on Chip.
Modifie ConsoleControle to match even more needs. (Like a way to check and wait for the current process to be done without the affect that your whole code stops and will cause a crash of your app).


Credits and Greets:
-------------------
Judges for his SPIway.py script (many thx)
Dave Kerr for his Console Controle Class librarie
eussNL for his affinity about the DevWiki (woop woop)
flatz for his PS4 unPKG.py script
grafchockolo for all his amazing work on the PS3 (i will always credit you in any scene releaded stuff ;) thank you for everything you have done. We would need more guys like you in the Sony Playstation Hacking Scene)
KDSBest for beeing a Mentor and a god frind to me
GotNoUsername you know why and that's enough :)
All Devwiki Contributors !! (information have to be free to every one)
Pockets69, Sandungas, Helsing9, GregoryRasputin, t000, Ada, _NiceShot, PS3hax.net, PS4hax.net, psx-scene.com and everyone else i forgot....(wink, wink)