﻿/*
' Copyright (c) 2019-2022 Christoc.com
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/


using System;
using DotNetNuke.Framework;

namespace Christoc.Skins.HammerFlex2
{
    public class SkinBase : DotNetNuke.UI.Skins.Skin
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterJavaScript();
        }

        private void RegisterJavaScript()
        {
            jQuery.RequestRegistration();
            
        }
    }
}