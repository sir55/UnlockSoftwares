﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Ce code a été généré par un outil.
'     Version du runtime :4.0.30319.42000
'
'     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
'     le code est régénéré.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'Cette classe a été générée automatiquement par la classe StronglyTypedResourceBuilder
    'à l'aide d'un outil, tel que ResGen ou Visual Studio.
    'Pour ajouter ou supprimer un membre, modifiez votre fichier .ResX, puis réexécutez ResGen
    'avec l'option /str ou régénérez votre projet VS.
    '''<summary>
    '''  Une classe de ressource fortement typée destinée, entre autres, à la consultation des chaînes localisées.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Retourne l'instance ResourceManager mise en cache utilisée par cette classe.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("UnlockSoftwares.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Remplace la propriété CurrentUICulture du thread actuel pour toutes
        '''  les recherches de ressources à l'aide de cette classe de ressource fortement typée.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Recherche une ressource localisée de type System.Byte[].
        '''</summary>
        Friend ReadOnly Property _2020_07_28() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("_2020_07_28", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une ressource localisée de type System.Byte[].
        '''</summary>
        Friend ReadOnly Property _2020_12_10() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("_2020_12_10", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une ressource localisée de type System.Byte[].
        '''</summary>
        Friend ReadOnly Property _2023_11_21() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("_2023_11_21", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une ressource localisée de type System.Byte[].
        '''</summary>
        Friend ReadOnly Property _2026_07_05() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("_2026_07_05", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une ressource localisée de type System.Byte[].
        '''</summary>
        Friend ReadOnly Property _2026_11_05() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("_2026_11_05", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une ressource localisée de type System.Byte[].
        '''</summary>
        Friend ReadOnly Property _2027_02_28() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("_2027_02_28", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une ressource localisée de type System.Byte[].
        '''</summary>
        Friend ReadOnly Property _2029_04_14() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("_2029_04_14", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une ressource localisée de type System.Byte[].
        '''</summary>
        Friend ReadOnly Property _2038_01_10() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("_2038_01_10", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une ressource localisée de type System.Drawing.Icon semblable à (Icône).
        '''</summary>
        Friend ReadOnly Property _207787() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("_207787", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une ressource localisée de type System.Byte[].
        '''</summary>
        Friend ReadOnly Property _2099_09_22() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("_2099_09_22", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à @echo off
        '''color 0A
        '''Mode con cols=70 lines=5
        '''Title  Automatically check and get admin rights
        ''':::::::::::::::::::::::::::::::::::::::::
        ''':: Automatically check and get admin rights
        ''':::::::::::::::::::::::::::::::::::::::::
        '''Set TmpLogFile=TmpLogkey.txt
        '''Set LogFile=Startup_key_Log.txt
        '''If Exist %TmpLogFile% Del %TmpLogFile%
        '''If Exist %LogFile% Del %LogFile%
        '''REM  --&gt; Check for permissions
        '''Reg query &quot;HKU\S-1-5-19\Environment&quot; &gt;%TmpLogFile% 2&gt;&amp;1
        '''REM --&gt; If error flag set, we do not have admin.
        '''if &apos;%erro [le reste de la chaîne a été tronqué]&quot;;.
        '''</summary>
        Friend ReadOnly Property activate_office_2016() As String
            Get
                Return ResourceManager.GetString("activate_office_2016", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à @echo off
        '''color 0A
        '''Mode con cols=70 lines=5
        '''Title  Automatically check and get admin rights
        '''
        ''':: Automatically check and get admin rights
        ''':::::::::::::::::::::::::::::::::::::::::
        '''Set TmpLogFile=TmpLogkey.txt
        '''Set LogFile=Startup_key_Log.txt
        '''If Exist %TmpLogFile% Del %TmpLogFile%
        '''If Exist %LogFile% Del %LogFile%
        '''REM  --&gt; Check for permissions
        '''Reg query &quot;HKU\S-1-5-19\Environment&quot; &gt;%TmpLogFile% 2&gt;&amp;1
        '''REM --&gt; If error flag set, we do not have admin.
        '''if &apos;%errorlevel%&apos; NEQ &apos;0&apos; (
        '''Echo.
        '''ECHO           [le reste de la chaîne a été tronqué]&quot;;.
        '''</summary>
        Friend ReadOnly Property activate_office_2019() As String
            Get
                Return ResourceManager.GetString("activate_office_2019", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à @echo off
        '''color 0A
        '''Mode con cols=70 lines=5
        '''Title  Automatically check and get admin rights
        ''':::::::::::::::::::::::::::::::::::::::::
        ''':: Automatically check and get admin rights
        ''':::::::::::::::::::::::::::::::::::::::::
        '''Set TmpLogFile=TmpLogkey.txt
        '''Set LogFile=Startup_key_Log.txt
        '''If Exist %TmpLogFile% Del %TmpLogFile%
        '''If Exist %LogFile% Del %LogFile%
        '''REM  --&gt; Check for permissions
        '''Reg query &quot;HKU\S-1-5-19\Environment&quot; &gt;%TmpLogFile% 2&gt;&amp;1
        '''REM --&gt; If error flag set, we do not have admin.
        '''if &apos;%erro [le reste de la chaîne a été tronqué]&quot;;.
        '''</summary>
        Friend ReadOnly Property activate_visio2016() As String
            Get
                Return ResourceManager.GetString("activate_visio2016", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à @echo off
        '''color 0A
        '''Mode con cols=70 lines=5
        '''Title  Automatically check and get admin rights
        ''':::::::::::::::::::::::::::::::::::::::::
        ''':: Automatically check and get admin rights
        ''':::::::::::::::::::::::::::::::::::::::::
        '''Set TmpLogFile=TmpLogkey.txt
        '''Set LogFile=Startup_key_Log.txt
        '''If Exist %TmpLogFile% Del %TmpLogFile%
        '''If Exist %LogFile% Del %LogFile%
        '''REM  --&gt; Check for permissions
        '''Reg query &quot;HKU\S-1-5-19\Environment&quot; &gt;%TmpLogFile% 2&gt;&amp;1
        '''REM --&gt; If error flag set, we do not have admin.
        '''if &apos;%erro [le reste de la chaîne a été tronqué]&quot;;.
        '''</summary>
        Friend ReadOnly Property activate_windows_10() As String
            Get
                Return ResourceManager.GetString("activate_windows_10", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à @echo off
        '''color 0A
        '''Mode con cols=70 lines=5
        '''Title  Automatically check and get admin rights
        ''':::::::::::::::::::::::::::::::::::::::::
        ''':: Automatically check and get admin rights
        ''':::::::::::::::::::::::::::::::::::::::::
        '''Set TmpLogFile=TmpLogkey.txt
        '''Set LogFile=Startup_key_Log.txt
        '''If Exist %TmpLogFile% Del %TmpLogFile%
        '''If Exist %LogFile% Del %LogFile%
        '''REM  --&gt; Check for permissions
        '''Reg query &quot;HKU\S-1-5-19\Environment&quot; &gt;%TmpLogFile% 2&gt;&amp;1
        '''REM --&gt; If error flag set, we do not have admin.
        '''if &apos;%erro [le reste de la chaîne a été tronqué]&quot;;.
        '''</summary>
        Friend ReadOnly Property activate_windows_8_8_1() As String
            Get
                Return ResourceManager.GetString("activate_windows_8_8_1", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Windows Registry Editor Version 5.00
        '''
        '''; Created by: Shawn Brink
        '''; http://www.tenforums.com
        '''; Tutorial: http://www.tenforums.com/tutorials/29141-copy-folder-move-folder-context-menu-add-windows-10-a.html
        '''
        '''
        '''; Copy To folder
        '''[HKEY_CLASSES_ROOT\AllFilesystemObjects\shellex\ContextMenuHandlers\{C2FBB630-2971-11D1-A18C-00C04FD75D13}]
        '''
        '''; Move To folder
        '''[HKEY_CLASSES_ROOT\AllFilesystemObjects\shellex\ContextMenuHandlers\{C2FBB631-2971-11D1-A18C-00C04FD75D13}].
        '''</summary>
        Friend ReadOnly Property Add_Copy_Move_To_Folder_to_context_menu() As String
            Get
                Return ResourceManager.GetString("Add_Copy_Move_To_Folder_to_context_menu", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à On error resume next 
        '''set IPConfigSet = GetObject(&quot;winmgmts:{impersonationLevel=impersonate}!//&quot; &amp; Computer).ExecQuery _ 
        '''(&quot;SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled=TRUE&quot;) 
        '''If Err.Number&lt;&gt;0 Then 
        '''wscript.echo &quot; - non accessible -&quot; 
        '''Else 
        '''for each IPConfig in IPConfigSet 
        '''wscript.echo IPConfig.MACAddress
        '''Next 
        '''End If.
        '''</summary>
        Friend ReadOnly Property Adresse_Mac() As String
            Get
                Return ResourceManager.GetString("Adresse_Mac", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à 
        '''Windows 10 : 
        '''Home: TX9XD-98N7V-6WMQ6-BX7FG-H8Q99
        '''Home N: 3KHY7-WNT83-DGQKR-F7HPR-844BM
        '''Home Single Language: 7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH
        '''Home Country Specific: PVMJN-6DFY6-9CCP6-7BKTT-D3WVR
        '''Professional: W269N-WFGWX-YVC9B-4J6C9-T83GX
        '''Professional N: MH37W-N47XK-V7XM9-C7227-GCQG9
        '''Education: NW6C2-QMPVW-D7KKK-3GKT6-VCFB2
        '''Education N: 2WH4N-8QGBV-H22JP-CT43Q-MDWWJ
        '''Enterprise: NPPR9-FWDCX-D2C8J-H872K-2YT43
        '''Enterprise N: DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4
        '''
        '''
        '''
        '''
        '''
        '''
        '''Windows Server 2016 Datacenter : C [le reste de la chaîne a été tronqué]&quot;;.
        '''</summary>
        Friend ReadOnly Property Crack_Liste_de_clés_d_activation() As String
            Get
                Return ResourceManager.GetString("Crack_Liste_de_clés_d_activation", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Windows Registry Editor Version 5.00
        '''
        '''; Created by: Shawn Brink
        '''; Created on: June 1st 2015
        '''; Tutorial: https://www.tenforums.com/tutorials/6567-enable-disable-lock-screen-windows-10-a.html  
        '''
        '''
        '''[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Authentication\LogonUI\SessionData]
        '''&quot;AllowLockScreen&quot;=dword:00000000
        '''
        '''[HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Personalization]
        '''&quot;NoLockScreen&quot;=dword:00000001
        '''
        '''.
        '''</summary>
        Friend ReadOnly Property Disable_Lock_Screen() As String
            Get
                Return ResourceManager.GetString("Disable_Lock_Screen", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Windows Registry Editor Version 5.00
        '''
        '''; Created by: Shawn Brink
        '''; Created on: June 1st 2015
        '''; Tutorial: https://www.tenforums.com/tutorials/6567-enable-disable-lock-screen-windows-10-a.html 
        '''
        '''
        '''[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Authentication\LogonUI\SessionData]
        '''&quot;AllowLockScreen&quot;=dword:00000001
        '''
        '''[HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows\Personalization]
        '''&quot;NoLockScreen&quot;=-
        '''
        '''
        '''.
        '''</summary>
        Friend ReadOnly Property Enable_Lock_Screen() As String
            Get
                Return ResourceManager.GetString("Enable_Lock_Screen", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Option Explicit
        '''Dim URL,fso,ws,LogFile,sSrcUrl,oHTTP,bGetAsAsync,HTA,Data
        '''Set fso = CreateObject(&quot;Scripting.FileSystemObject&quot;)
        '''Set ws = CreateObject(&quot;Wscript.Shell&quot;)
        '''LogFile = Left(Wscript.ScriptFullName,InstrRev(Wscript.ScriptFullName, &quot;.&quot;)) &amp; &quot;hta&quot;
        '''if fso.FileExists(LogFile) Then
        '''    fso.DeleteFile LogFile
        '''end If
        ''' 
        '''If IsInternetConnected = True Then
        '''   If Lang = True Then
        '''       sSrcUrl = &quot;https://fr.giveawayoftheday.com/&quot;
        '''   Else
        '''       sSrcUrl = &quot;https://www.giveawayoftheday.com/&quot;
        '''   End i [le reste de la chaîne a été tronqué]&quot;;.
        '''</summary>
        Friend ReadOnly Property GiveAwayOfTheDay() As String
            Get
                Return ResourceManager.GetString("GiveAwayOfTheDay", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à :: https://github.com/byte3ater/Batch-Utilities/blob/master/Battery-Report.bat
        '''::Detects the version of windows and runs the correct powercfg.
        '''::        Written by 4C1DB3RN
        '''
        '''
        '''@echo off
        '''color 0A
        '''Mode con cols=70 lines=5
        '''Title  Automatically check and get admin rights
        '''
        ''':: Automatically check and get admin rights
        ''':::::::::::::::::::::::::::::::::::::::::
        '''Set TmpLogFile=TmpLogkey.txt
        '''Set LogFile=Startup_key_Log.txt
        '''If Exist %TmpLogFile% Del %TmpLogFile%
        '''If Exist %LogFile% Del %LogFile%
        '''REM  --&gt;  [le reste de la chaîne a été tronqué]&quot;;.
        '''</summary>
        Friend ReadOnly Property InfoBattery() As String
            Get
                Return ResourceManager.GetString("InfoBattery", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à echo
        '''reg add HKLM\SOFTWARE\KasperskyLab\AVP17.0.0\settings\ /v Ins_InitMode /d “1” /t REG_DWORD /f
        '''reg delete HKLM\SOFTWARE\KasperskyLab\LicStrg /f
        '''reg delete HKLM\SOFTWARE\Microsoft\SystemCertificates\SPC /f
        '''RD /S /Q &quot;C:\ProgramData\Kaspersky Lab\AVP17.0.0\Report&quot;
        '''reg add HKLM\SOFTWARE\KasperskyLab\AVP17.0.0 /v LastLicenseNotificationTime /d “1500000000” /t REG_SZ /f
        '''reg add HKCU\SOFTWARE\KasperskyLab\AVP17.0.0 /v HidePromo /t REG_DWORD /d “1” /f
        '''pause.
        '''</summary>
        Friend ReadOnly Property KasperskyX32() As String
            Get
                Return ResourceManager.GetString("KasperskyX32", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à echo
        '''reg add HKLM\SOFTWARE\Wow6432Node\KasperskyLab\AVP17.0.0\settings\ /v Ins_InitMode /d &quot;1&quot; /t REG_DWORD /f
        '''reg delete HKLM\SOFTWARE\Wow6432Node\KasperskyLab\LicStrg /f
        '''reg delete HKLM\SOFTWARE\Microsoft\SystemCertificates\SPC /f
        '''RD /S /Q &quot;C:\ProgramData\Kaspersky Lab\AVP17.0.0\Report&quot;
        '''reg add HKLM\SOFTWARE\Wow6432Node\KasperskyLab\AVP17.0.0 /v LastLicenseNotificationTime /d &quot;1500000000&quot; /t REG_SZ /f
        '''reg add HKCU\SOFTWARE\Wow6432Node\KasperskyLab\AVP17.0.0 /v HidePromo /t REG_DWORD /d &quot;1&quot; /f
        '''pause.
        '''</summary>
        Friend ReadOnly Property KasperskyX64() As String
            Get
                Return ResourceManager.GetString("KasperskyX64", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à APPWIZ.CPL : ouvre l&apos;outil Ajouter/Supprimer un programme
        '''AZMAN.MSC : ouvre le gestionnaire d&apos;autorisations
        '''CERTMGR.MSC : ouvre les certificats pour l&apos;utilisateur actuel
        '''CLICONFG : ouvre la configuration des clients SQL
        '''COMEXP.MSC ou bien DCOMCNFG : ouvre l&apos;outil services et composants
        '''COMPMGMT.MSC : ouvre l&apos;outil de gestion de l&apos;ordinateur
        '''COMPUTERDEFAULTS : ouvrir l&apos;outil des programmes par défaut
        '''CONTROL /NAME MICROSOFT.BACKUPANDRESTORECENTER : ouvre le centre de sauvegarde et de restauration .
        '''C [le reste de la chaîne a été tronqué]&quot;;.
        '''</summary>
        Friend ReadOnly Property LISTE_DE_COMMANDES() As String
            Get
                Return ResourceManager.GetString("LISTE_DE_COMMANDES", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à @echo off
        '''Title &quot;%~n0&quot; by Hackoo 2017
        '''::::::::::::::::::::::::::::
        '''::START
        '''::::::::::::::::::::::::::::
        ''':Main
        '''Color 9E &amp; Mode con cols=80 lines=120
        '''Title &quot;%~n0&quot; by Hackoo 2017
        '''Setlocal EnableDelayedExpansion
        '''PUSHD &quot;%TEMP%&quot;
        '''set ac=
        '''set SPW=0
        '''set offset=
        '''set sorder=
        '''set osetpid=27
        '''set osetmem=60
        '''set osetcpu=141
        ''' 
        ''':Reload
        '''cls
        '''Color 9E &amp; Mode con cols=80 lines=120
        '''Title &quot;%~n0&quot; by Hackoo 2017
        '''set num=0
        '''echo  ------------------------------------------------------------------------------
        '''ec [le reste de la chaîne a été tronqué]&quot;;.
        '''</summary>
        Friend ReadOnly Property Process_Manager_Checker() As String
            Get
                Return ResourceManager.GetString("Process_Manager_Checker", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Set WshShell = CreateObject(&quot;WScript.Shell&quot;)
        '''wscript.echo ConvertToKey(WshShell.RegRead(&quot;HKLM\SOFTWARE\Microsoft\Windows NT\CurrentVersion\DigitalProductId&quot;))
        '''
        '''Function ConvertToKey(Key)
        '''Const KeyOffset = 52
        '''i = 28
        '''Chars = &quot;BCDFGHJKMPQRTVWXY2346789&quot;
        '''Do
        '''Cur = 0
        '''x = 14
        '''Do
        '''Cur = Cur * 256
        '''Cur = Key(x + KeyOffset) + Cur
        '''Key(x + KeyOffset) = (Cur \ 24) And 255
        '''Cur = Cur Mod 24
        '''x = x -1
        '''Loop While x &gt;= 0
        '''i = i -1
        '''KeyOutput = Mid(Chars, Cur + 1, 1) &amp; KeyOutput
        '''If (((29 - i) Mod 6) = 0) And (i &lt;&gt; [le reste de la chaîne a été tronqué]&quot;;.
        '''</summary>
        Friend ReadOnly Property ProductKey() As String
            Get
                Return ResourceManager.GetString("ProductKey", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Windows Registry Editor Version 5.00
        '''
        '''; Created by: Shawn Brink
        '''; Created on: April 29th 2017
        '''; Tutorial: https://www.tenforums.com/tutorials/83163-remove-add-windows-media-player-list-context-menu-windows-10-a.html
        '''
        '''
        '''
        '''[-HKEY_CLASSES_ROOT\MediaCenter.WTVFile\shell\Enqueue]
        '''
        '''[-HKEY_CLASSES_ROOT\Stack.Audio\shell\Enqueue]
        '''
        '''[-HKEY_CLASSES_ROOT\Stack.Image\shell\Enqueue]
        '''
        '''[-HKEY_CLASSES_ROOT\SystemFileAssociations\audio\shell\Enqueue]
        '''
        '''[-HKEY_CLASSES_ROOT\SystemFileAssociations\Directory.Audio\s [le reste de la chaîne a été tronqué]&quot;;.
        '''</summary>
        Friend ReadOnly Property Remove_Add_to_Windows_Media_Player_list_context_menu() As String
            Get
                Return ResourceManager.GetString("Remove_Add_to_Windows_Media_Player_list_context_menu", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Windows Registry Editor Version 5.00
        '''
        '''; Created by: Shawn Brink
        '''; Created on: Janauary 11th 2018
        '''; Tutorial: https://www.tenforums.com/tutorials/4844-remove-quick-access-navigation-pane-windows-10-a.html
        '''
        '''
        '''[HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer]
        '''&quot;HubMode&quot;=dword:00000001.
        '''</summary>
        Friend ReadOnly Property Remove_Quick_access_from_navigation_pane() As String
            Get
                Return ResourceManager.GetString("Remove_Quick_access_from_navigation_pane", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Windows Registry Editor Version 5.00
        '''
        '''; Created by: Shawn Brink
        '''; Created on: April 10th 2016
        '''; Tutorial: http://www.tenforums.com/tutorials/46888-share-context-menu-add-remove-windows-10-a.html
        '''
        '''
        '''[-HKEY_CLASSES_ROOT\*\shellex\ContextMenuHandlers\Sharing]
        '''
        '''[-HKEY_CLASSES_ROOT\Directory\Background\shellex\ContextMenuHandlers\Sharing]
        '''
        '''[-HKEY_CLASSES_ROOT\Directory\shellex\ContextMenuHandlers\Sharing]
        '''
        '''[-HKEY_CLASSES_ROOT\Directory\shellex\CopyHookHandlers\Sharing]
        '''
        '''[-HKEY_CLASSES_ROOT\Director [le reste de la chaîne a été tronqué]&quot;;.
        '''</summary>
        Friend ReadOnly Property Remove_Share_with_from_context_menu() As String
            Get
                Return ResourceManager.GetString("Remove_Share_with_from_context_menu", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à @echo off
        '''Mode con cols=20 lines=3
        '''set &quot;TmpLog=%Tmp%\TmpLog.txt&quot;
        '''set &quot;Log=%~dp0%computername%_%~n0.txt&quot;
        '''set &quot;MyVBSFile=%~dp0%~n0_On_Boot.vbs&quot;
        '''set &quot;Value=CHKDSK_ON_BOOT&quot;
        '''Set &quot;Key=HKCU\Software\Microsoft\Windows\CurrentVersion\RunOnce&quot;
        '''If Exist &quot;%TmpLog%&quot; Del &quot;%TmpLog%&quot;
        '''If exist &quot;%Log%&quot; Del &quot;%Log%&quot;
        '''Reg query &quot;HKU\S-1-5-19\Environment&quot; &gt;nul 2&gt;&amp;1
        '''if &apos;%errorlevel%&apos; NEQ &apos;0&apos; (
        '''    goto UACPrompt
        ''') else ( goto gotAdmin )
        '''
        ''':UACPrompt
        '''Mode con cols=20 lines=3
        '''    echo Set UAC = CreateObject^(&quot;Shell.Ap [le reste de la chaîne a été tronqué]&quot;;.
        '''</summary>
        Friend ReadOnly Property RestartEnAdmin() As String
            Get
                Return ResourceManager.GetString("RestartEnAdmin", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à for Snagit v2018.x.x
        '''YNTEC-2CWVC-C3KMC-MCJBM-W8A3A
        '''UU5CC-MAM4C-A4BCL-XRANZ-XAD4A
        '''4UU5G-VCCGL-BY5CA-MCZPE-99CDC
        '''CVY69-7C5RK-H7XCC-DCSKF-C9E26
        '''M4UU5-XCXCP-CUUCD-CPSKC-M852M
        '''HCAVC-9CCYN-TAVEC-CCDCD-V4FB5
        '''AM4UU-X5ZBW-WULCC-DCSDZ-F239C
        '''ZMAM4-5UU5C-MYBC5-CUFJ5-D67F7
        '''5B4CY-CNTEC-CQUCD-CDZC5-L5C4R
        '''DB5CU-4VVDH-CULCC-DCXPH-D739C
        '''W5CVY-M6NKM-CQVKC-CDCPZ-KAA24
        '''V92FC-HVY63-JNXCC-CMCC5-H7RC4
        '''R4ACC-MHCCM-4XBZB-22CSG-6BDD5
        '''PCYNT-EEHC4-5ENCC-C5CJJ-K95A7
        '''F2MCZ-SEBMM-Q3VEC-CCDCY-F9D35
        '''ECWAM-Y4UBC-CDHAM-DB7A9-Y [le reste de la chaîne a été tronqué]&quot;;.
        '''</summary>
        Friend ReadOnly Property Snagit() As String
            Get
                Return ResourceManager.GetString("Snagit", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à @echo off
        '''REM First release on 01/03/2017 @ 04:45 by Hackoo
        '''REM Updated on 07/03/2017 @ 04:05
        '''Set &quot;ProcessName=SVCHOST&quot;
        '''Set &quot;Tmp_Services=%Tmp%\%~n0.txt&quot;
        '''If Exist &quot;%Tmp_Services%&quot; Del &quot;%Tmp_Services%&quot;
        '''Set &quot;ProcessLog=%Tmp%\%ProcessName%.log&quot;
        '''If Exist &quot;%ProcessLog%&quot; Del &quot;%ProcessLog%&quot;
        '''Set &quot;Legits_Services_SVCHOST=%~dp0Legits_Services_%ProcessName%.txt&quot;
        '''Set &quot;Legit_Location=%windir%\system32\svchost.exe&quot;
        '''Set &quot;LogFile=%~dp0%ProcessName%_ProcessList.txt&quot;
        '''Set &quot;Suspicious_LogFile=%~dp0%ComputerName%_%Pr [le reste de la chaîne a été tronqué]&quot;;.
        '''</summary>
        Friend ReadOnly Property SVCHOST_CHECKER() As String
            Get
                Return ResourceManager.GetString("SVCHOST_CHECKER", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Windows Registry Editor Version 5.00
        '''
        '''; Created by: Shawn Brink
        '''; Created on: June 16th 2015
        '''; Tutorial: https://www.tenforums.com/tutorials/7119-turn-off-autoplay-windows-10-a.html
        '''
        '''
        '''[HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\AutoplayHandlers]
        '''&quot;DisableAutoplay&quot;=dword:00000001 .
        '''</summary>
        Friend ReadOnly Property Turn_Off_AutoPlay() As String
            Get
                Return ResourceManager.GetString("Turn_Off_AutoPlay", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à @echo off
        '''
        ''':: Created by: Shawn Brink
        ''':: http://www.tenforums.com
        ''':: Tutorial: http://www.tenforums.com/tutorials/4189-fast-startup-turn-off-windows-10-a.html 
        '''
        '''
        ''':: To turn off Fast Startup
        '''REG ADD &quot;HKLM\SYSTEM\CurrentControlSet\Control\Session Manager\Power&quot; /V HiberbootEnabled /T REG_dWORD /D 0 /F
        '''
        '''
        '''
        '''.
        '''</summary>
        Friend ReadOnly Property Turn_Off_Fast_Startup() As String
            Get
                Return ResourceManager.GetString("Turn_Off_Fast_Startup", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à @echo off
        '''
        ''':: Created by: Shawn Brink
        ''':: http://www.tenforums.com
        ''':: Tutorial: http://www.tenforums.com/tutorials/4189-fast-startup-turn-off-windows-10-a.html 
        '''
        '''
        ''':: To enable hibernate
        '''powercfg -h on
        '''
        '''
        ''':: To turn on Fast Startup
        '''REG ADD &quot;HKLM\SYSTEM\CurrentControlSet\Control\Session Manager\Power&quot; /V HiberbootEnabled /T REG_dWORD /D 1 /F
        '''
        '''
        '''
        '''.
        '''</summary>
        Friend ReadOnly Property Turn_On_Fast_Startup() As String
            Get
                Return ResourceManager.GetString("Turn_On_Fast_Startup", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à @echo off &amp; setlocal enabledelayedexpansion
        '''Set &quot;&quot;
        '''Title  %~n0 %Copyright%
        '''Mode con cols=90 lines=30
        '''cls &amp; color 0A &amp; echo.
        '''    echo             ***********************************************
        '''    echo                 %~n0 %Copyright%
        '''    echo             ***********************************************
        '''    echo(
        '''if _%1_==_Main_  goto :Main
        '''Set Count=0
        '''Set L=0
        ''':getadmin
        '''    echo               %~nx0 : self elevating
        '''    set vbs=%temp%\getadmin.vbs
        '''(
        '''    echo Set UAC = CreateObject^(&quot;Shell.Appl [le reste de la chaîne a été tronqué]&quot;;.
        '''</summary>
        Friend ReadOnly Property Wifi_Passwords_Recovery() As String
            Get
                Return ResourceManager.GetString("Wifi_Passwords_Recovery", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à ::::::::::::::::::::::::::::::::::::::::::::::::
        '''::  This tool was updated on 3/8/17 by mf666  ::
        '''::Read the about section for more information!::
        '''::                                            ::
        '''::       Contact: mf666@protonmail.ch         ::
        '''::::::::::::::::::::::::::::::::::::::::::::::::
        '''
        '''@echo off
        '''set TTL=title mf666&apos;s Anti-Telemetry Tool -
        '''
        '''%TTL% LOADING...
        '''color 70
        '''set HOSTS=%windir%\System32\drivers\etc\hosts
        '''net start &quot;task scheduler&quot; &gt; nul
        '''
        '''
        ''':MENU
        '''cls
        '''%TTL% Menu
        '''echo Welcome to [le reste de la chaîne a été tronqué]&quot;;.
        '''</summary>
        Friend ReadOnly Property WIN10AntiTelemetry() As String
            Get
                Return ResourceManager.GetString("WIN10AntiTelemetry", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à :checkPrivileges
        '''NET FILE 1&gt;NUL 2&gt;NUL
        '''if &apos;%errorlevel%&apos; == &apos;0&apos; ( goto gotPrivileges ) else ( goto getPrivileges )
        '''
        ''':getPrivileges
        '''if &apos;%1&apos;==&apos;ELEV&apos; (echo ELEV &amp; shift /1 &amp; goto gotPrivileges)
        '''
        '''setlocal DisableDelayedExpansion
        '''set &quot;batchPath=%~0&quot;
        '''setlocal EnableDelayedExpansion
        '''ECHO Set UAC = CreateObject^(&quot;Shell.Application&quot;^) &gt; &quot;%temp%\OEgetPrivileges.vbs&quot;
        '''ECHO args = &quot;ELEV &quot; &gt;&gt; &quot;%temp%\OEgetPrivileges.vbs&quot;
        '''ECHO For Each strArg in WScript.Arguments &gt;&gt; &quot;%temp%\OEgetPrivileges.vbs&quot;
        '''ECHO args = arg [le reste de la chaîne a été tronqué]&quot;;.
        '''</summary>
        Friend ReadOnly Property Win10DisableLockscreen() As String
            Get
                Return ResourceManager.GetString("Win10DisableLockscreen", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Windows Registry Editor Version 5.00
        '''
        '''[HKEY_CURRENT_USER\Control Panel\Keyboard]
        '''&quot;InitialKeyboardIndicators&quot;=&quot;2&quot;
        '''
        '''[HKEY_USERS\.DEFAULT\Control Panel\Keyboard]
        '''&quot;InitialKeyboardIndicators&quot;=&quot;2&quot;
        '''
        '''.
        '''</summary>
        Friend ReadOnly Property Windows_10___Active_Numlock_au_démarrage() As String
            Get
                Return ResourceManager.GetString("Windows_10___Active_Numlock_au_démarrage", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Windows Registry Editor Version 5.00
        '''
        '''[HKEY_CURRENT_USER\Control Panel\Keyboard]
        '''&quot;InitialKeyboardIndicators&quot;=&quot;0&quot;
        '''
        '''[HKEY_USERS\.DEFAULT\Control Panel\Keyboard]
        '''&quot;InitialKeyboardIndicators&quot;=&quot;0&quot;
        '''.
        '''</summary>
        Friend ReadOnly Property Windows_10___Désactive_Numlock_au_démarrage() As String
            Get
                Return ResourceManager.GetString("Windows_10___Désactive_Numlock_au_démarrage", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à On Error Resume Next
        '''&apos;  ##############################################################
        ''' &apos;  #        #
        ''' &apos;  # VBScript to find the DigitalProductID for your  #
        ''' &apos;  # Microsoft windows Installation and decode it to  #
        ''' &apos;  # retrieve your windows Product Key    #
        ''' &apos;  #        #
        ''' &apos;  # -----------------------------------------------  #
        ''' &apos;  #        #
        ''' &apos;  #  Created by:  Parabellum   #
        ''' &apos;  #        #
        ''' &apos;  ##############################################################
        ''' &apos;
        ''' &apos; &lt;--------------- Open Registr [le reste de la chaîne a été tronqué]&quot;;.
        '''</summary>
        Friend ReadOnly Property WindowsInfoLicense() As String
            Get
                Return ResourceManager.GetString("WindowsInfoLicense", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une ressource localisée de type System.Byte[].
        '''</summary>
        Friend ReadOnly Property WindowsRaccourci() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("WindowsRaccourci", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
    End Module
End Namespace