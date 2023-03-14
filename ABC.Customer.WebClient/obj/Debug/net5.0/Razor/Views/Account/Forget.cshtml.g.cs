#pragma checksum "C:\Users\lalam\OneDrive\Documents\ABC\ABC.Customer.WebClient\Views\Account\Forget.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d93d223804c2e9192ea1eb87b12f706679d4b106"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Forget), @"mvc.1.0.view", @"/Views/Account/Forget.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d93d223804c2e9192ea1eb87b12f706679d4b106", @"/Views/Account/Forget.cshtml")]
    public class Views_Account_Forget : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ABC.EFCore.Repository.Edmx.ForgetPassword>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\lalam\OneDrive\Documents\ABC\ABC.Customer.WebClient\Views\Account\Forget.cshtml"
  
    ViewData["Title"] = "Forget";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lalam\OneDrive\Documents\ABC\ABC.Customer.WebClient\Views\Account\Forget.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\lalam\OneDrive\Documents\ABC\ABC.Customer.WebClient\Views\Account\Forget.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\lalam\OneDrive\Documents\ABC\ABC.Customer.WebClient\Views\Account\Forget.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""my-3"">
        <div class=""container"">
            <div class=""row justify-content-center"">
                <div class=""col-md-8 col-lg-5 col-xl-5"">
                    <div class=""card mx-4 bg-light"">
                        <div class=""card-body"">

                            <div class=""d-flex p-3"">
                                <div class=""ms-auto text-end"">
                                    <h4 class=""font-size-18"">Forget Password</h4>
                                </div>
                            </div>
                            <div class=""p-3"">
                                <div class=""alert alert-success"" role=""alert"" id=""lblForgetPassword"">
                                    Enter your email for new password !
                                </div>



                                <div class=""mb-3"">
                                    ");
#nullable restore
#line 33 "C:\Users\lalam\OneDrive\Documents\ABC\ABC.Customer.WebClient\Views\Account\Forget.cshtml"
                               Write(Html.EditorFor(model => model.Email, new { htmlAttributes = new { @class = "form-control", id = "useremail", placeholder = "Enter Your Email" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 34 "C:\Users\lalam\OneDrive\Documents\ABC\ABC.Customer.WebClient\Views\Account\Forget.cshtml"
                               Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger db" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                               \r\n                                </div>\r\n                               \r\n                                <div class=\"mb-3\" style=\"display:none;\" id=\"otpdiv\">\r\n                                    ");
#nullable restore
#line 39 "C:\Users\lalam\OneDrive\Documents\ABC\ABC.Customer.WebClient\Views\Account\Forget.cshtml"
                               Write(Html.EditorFor(model => model.Otp, new { htmlAttributes = new { @class = "form-control", id = "userotp", placeholder = "Enter Your OTP" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 40 "C:\Users\lalam\OneDrive\Documents\ABC\ABC.Customer.WebClient\Views\Account\Forget.cshtml"
                               Write(Html.ValidationMessageFor(model => model.Otp, "", new { @class = "text-danger db" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>

                                <div class=""mb-3"">
                                    <div class=""text-end"">
                                        <a  class=""btn btn-primary"" style=""color:white"" id=""sendotp"">Send OTP</a>
                                        <button class=""btn btn-success  float-right"" type=""submit"" id=""Verify"" style=""display:none"">Verify</button>
                                    </div>
                                </div>


                            </div>

                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 60 "C:\Users\lalam\OneDrive\Documents\ABC\ABC.Customer.WebClient\Views\Account\Forget.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
    <script>
        //$(document).ready(function () {
        //    $(""#sendotp"").click(function () {

        //        //$(""#lblForgetPassword"").html(""OTP Send To Your Registered Email Address."");
        //    });
        //});



        $(""#sendotp"").on('click', function () {
            var Email = $(""#useremail"").val();
            debugger

            //var record = {};
            //record = new FormData();
            if (Email != null && Email != """" && Email != ""undefined"") {
                //record.append(""Email"", Email);

                $.ajax({
                    //url: window.location.href = """);
#nullable restore
#line 83 "C:\Users\lalam\OneDrive\Documents\ABC\ABC.Customer.WebClient\Views\Account\Forget.cshtml"
                                              Write(Url.Action("SendOtp", "Account", new { @area = "Security" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("?email=\" + Email,\r\n                    url: \"");
#nullable restore
#line 84 "C:\Users\lalam\OneDrive\Documents\ABC\ABC.Customer.WebClient\Views\Account\Forget.cshtml"
                     Write(Url.Action("SendOtp", "Account", new{@area= "Security"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"?email="" + Email,
                    type: ""POST"",
                    data: Email ,
                    async: false,
                    dataType: ""json"",
                    processData: false,
                    contentType: false,
                    success: function (data) {
                        debugger
                        console.log(data);
                        if (data == ""OTP Sent Successfully"") {
                            $(""#otpdiv"").show();
                            $(""#Verify"").show();
                            $(""#lblForgetPassword"").html(""OTP Send To Your Registered Email Address."");
                        }
                    },
                    error: function () {

                    }
                });
            }
    });



    </script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ABC.EFCore.Repository.Edmx.ForgetPassword> Html { get; private set; }
    }
}
#pragma warning restore 1591