HammerFlex2
==========

Description
-----------
Another free open source skin for DNN (DotNetNuke) using Bootstrap 4.

Latest Release
--------------
V00.00.09 - 01/05/2022

Installation and Customization
------------------------------
You install this DNN Skin like any other DNN extension from the Host/Extensions page (do not install via Admin/Extensions), for production use download the INSTALL package from the releases page. For development you can either Fork the project here on GitHub, or you can download the source package. Install the SOURCE package into your development environment. The skin, as are all my modules, is designed for use in a local development environment at http://dnndev.me/ 

Development and Source Code Notes
---------------------------------
If you want to customize this skin, using the source code, here are the steps that I would recommend. 

1. Setup your development environment using the URL DNNDEV.ME you can follow this tutorial: https://christoc.com/Tutorials/All-Tutorials/Setting-up-your-DotNetNuke-Module-Development-Environment
2. Download the SOURCE package of the skin from GitHub
3. Install the SOURCE package of the skin from the Host/Extensions page
4. Open the CSPROJ file for the skin project, located in /portals/_default/skins/hammerflex2/
5. To repackage the skin, build in RELEASE mode. (if you want to change version numbers, change the numbers in AssemblyInfo.cs and hammerflex2.dnn)
6. You can find the new Packages for the Skin in the INSTALL folder /portals/_default/skins/hammerflex2/install
