#pragma checksum "C:\Users\lalam\OneDrive\Documents\ABC\ABC.Customer.WebClient\Views\Home\RegisterationScreen.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7cffc8c415d850a25bc1418445364805ed1dae94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RegisterationScreen), @"mvc.1.0.view", @"/Views/Home/RegisterationScreen.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cffc8c415d850a25bc1418445364805ed1dae94", @"/Views/Home/RegisterationScreen.cshtml")]
    public class Views_Home_RegisterationScreen : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\lalam\OneDrive\Documents\ABC\ABC.Customer.WebClient\Views\Home\RegisterationScreen.cshtml"
  
    ViewData["Title"] = "RegisterationScreen";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""col-lg-12"" style=""background-color: #f5f5f5; border: 1.5px solid gray;"">
        <div><center><h4 style=""font-size: 24px; font-weight: bold;""  >Registration Form</h4></center></div><br />
        <div><center><h4 style=""font-size: 15px; font-weight: bold;"">Come join the ABC Discounts as a Customer! Let's set up your Account</h4></center></div>
        <br />
        <div class=""row"">
            <div class=""col-lg-6"">
                <div class=""form-group"">
                    <label for=""FullName"">Full Name</label>
                    <input type=""email"" class=""form-control"" id=""FullName"" placeholder=""Like Steve"">
                </div>
            </div>
            <div class=""col-lg-6"">
                <div class=""form-group"">
                    <label for=""businessname"">Name of Business</label>
                    <input type=""email"" class=""form-control"" id=""businessname"" placeholder=""Name of Business"">
                </div>
            </div>");
            WriteLiteral(@"


        </div>


        <div class=""row"">
            <div class=""col-lg-6"">
                <div class=""form-group"">
                    <label for=""exampleFormControlInput1"">Email address</label>
                    <input type=""email"" class=""form-control"" id=""exampleFormControlInput1"" placeholder=""name@example.com"">
                </div>
            </div>
            <div class=""col-lg-6"">
                <div class=""form-group"">
                    <label for=""phone"">Phone</label>
                    <input type=""email"" class=""form-control"" id=""phone"" placeholder=""+1-12323321"">
                </div>
            </div>


        </div>

        <div class=""row"">
            <div class=""col-lg-6"">
                <div class=""form-group"">
                    <label for=""Password"">Password</label>
                    <input type=""password"" class=""form-control"" id=""Password"" placeholder=""Password"">
                </div>
            </div>
            <div class=""col-lg-6"">");
            WriteLiteral(@"
                <div class=""form-group"">
                    <label for=""confirmpassword"">Confirm Password</label>
                    <input type=""password"" class=""form-control"" id=""confirmpassword"" placeholder=""Confirm Password"">
                </div>
            </div>


        </div>

        <div class=""row"">
            <div class=""col-lg-6"">
                <div class=""form-group"">
                    <label");
            BeginWriteAttribute("for", " for=\"", 2586, "\"", 2592, 0);
            EndWriteAttribute();
            WriteLiteral(@">Mobile</label>
                    <input type=""text"" class=""form-control"" id=""Mobile"" placeholder=""Mobile"">
                </div>
            </div>
            <div class=""col-lg-6"">
                <div class=""form-group"">
                    <label for=""customertype"">Customer Type</label>
                    <select class=""form-control"" id=""customertype"">
                        <option>WholeSaler</option>
                        <option>Retailer</option>
                    </select>
                </div>
            </div>
        </div>

        <div class=""row"">
            <div class=""col-lg-6"">
                <div class=""form-group"">
                    <label for=""customerstate"">Customer State</label>
                    <select class=""form-control"" id=""customerstate"">
                        <option>
                            Select State
                        </option>
                        <option>
                            California
                        ");
            WriteLiteral(@"</option>
                        <option>
                            Washington
                        </option>
                        <option>
                            Texas
                        </option>
                        <option>
                            Hawali
                        </option>
                        <option>
                            Alaska
                        </option>
                        <option>
                            Florida
                        </option>
                    </select>
                </div>
            </div>
            <div class=""col-lg-6"">
                <div class=""form-group"">
                    <div class=""form-group"">
                        <label");
            BeginWriteAttribute("for", " for=\"", 4386, "\"", 4392, 0);
            EndWriteAttribute();
            WriteLiteral(@">State Resale Tax ID</label>
                        <input type=""text"" class=""form-control"" id=""stateresaletaxid"" placeholder=""State Resale Tax ID"">
                    </div>
                </div>
            </div>
        </div>

        <div class=""row"">
            <div class=""col-lg-6"">
                <div class=""form-group"">
                    <label for=""driverlisencestate"">Driver’s License Number</label>
                    <select class=""form-control"" id=""driverlisencestate"">
                        <option>
                            Select State
                        </option>
                        <option disabled>
                            California
                        </option>
                        <option>
                            North Carolina
                        </option>
                        <option disabled>
                            Washington
                        </option>
                        <option disabled>
              ");
            WriteLiteral(@"              Texas
                        </option>
                        <option disabled>
                            Hawali
                        </option>
                        <option disabled>
                            Alaska
                        </option>
                        <option disabled>
                            Florida
                        </option>
                    </select>
                </div>
            </div>
            <div class=""col-lg-6"">
                <div class=""form-group"">
                    <div class=""form-group"">
                        <label");
            BeginWriteAttribute("for", " for=\"", 6045, "\"", 6051, 0);
            EndWriteAttribute();
            WriteLiteral(@">License State</label>
                        <input type=""text"" class=""form-control"" id=""lisencestate"" placeholder=""License State"">
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-6"">
                <div class=""form-group"">
                    <label for=""cigrattelicenseno"">Cigratte License No</label>
                    <input type=""email"" class=""form-control"" id=""cigrattelicenseno"" placeholder=""Cigratte License No"">
                </div>
            </div>
            <div class=""col-lg-6"">
                <div class=""form-group"">
                    <label for=""tobaccolicenseno"">Tobacco License No</label>
                    <input type=""email"" class=""form-control"" id=""tobaccolicenseno"" placeholder=""Tobacco License No"">
                </div>
            </div>


        </div>
        <div class=""row"">
            <div class=""col-lg-6"">
                <div class=""form-group"">
        ");
            WriteLiteral("            <label for=\"cigrattelicenseno\">City</label>\r\n                    <input type=\"text\" class=\"form-control\" id=\"cigrattelicenseno\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 7215, "\"", 7229, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                </div>
            </div>
            <div class=""col-lg-6"">
                <div class=""form-group"">
                    <label for=""zip"">Zip</label>
                    <input type=""text"" class=""form-control"" id=""zip"" placeholder=""Zip"">
                </div>
            </div>


        </div>
        <br>
        <div class=""row"">
            <div class=""col-lg-6"">
                <div class=""custom-file"">
                    <label class=""custom-file-label"" for=""validatedCustomFile"">Faderal Text Form :</label>
                    <input type=""file"" class=""custom-file-input"" id=""federaltaxform"" required>

                    <div class=""invalid-feedback""></div>
                </div>
            </div>
            <div class=""col-lg-6"">
                <div class=""custom-file"">
                    <label class=""custom-file-label"" for=""validatedCustomFile"">Sale Tax ID:</label>
                    <input type=""file"" class=""custom-file-input"" id=""saletaxupload"" requ");
            WriteLiteral(@"ired>

                    <div class=""invalid-feedback""></div>
                </div>
            </div>


        </div>
        <br>
        <div class=""row"">
            <div class=""col-lg-6"">
                <div class=""custom-file"">
                    <label class=""custom-file-label"" for=""validatedCustomFile"">ID Copy/Driving License :</label>
                    <input type=""file"" class=""custom-file-input"" id=""validatedCustomFile"" required>

                    <div class=""invalid-feedback""></div>
                </div>
            </div>
            <div class=""col-lg-6"">
                <div class=""custom-control custom-checkbox"">
                    <label class=""custom-control-label"" for=""customCheck1"">TaxExempt</label>
                    <input type=""checkbox"" class=""custom-control-input"" id=""customCheck1"">

                </div>
            </div>


        </div>
        <br>
        <div class=""row"">
            <div class=""col-lg-4"">
            </div>
       ");
            WriteLiteral(@"     <div class=""col-lg-4"">
                <div class=""custom-control custom-radio"">
                    <input type=""radio"" id=""customRadio2"" name=""customRadio"" class=""custom-control-input"">
                    <label class=""custom-control-label"" for=""customRadio2"" style="" color: #FF5722;"">By clicking register, I agree to your terms</label>
                </div>
            </div>
            <div class=""col-lg-4"">
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-4"">
            </div>
            <div class=""col-lg-4"">
                <div class=""form-group"">
                    <label class=""col-md-4 control-label""></label>
                    <div class=""col-md-4"">
                        <br>
                        <button type=""submit"" class=""btn btn-warning"">SUBMIT <span class=""glyphicon glyphicon-send""></span></button>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4"">
            </");
            WriteLiteral("div>\r\n        </div>\r\n\r\n\r\n\r\n        <!-- Button -->\r\n       \r\n        <br>\r\n        <br>\r\n        <br>\r\n        \r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n<script>\r\n\r\n\r\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
