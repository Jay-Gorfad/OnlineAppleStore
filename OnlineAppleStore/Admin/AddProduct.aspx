<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="OnlineAppleStore.Admin.AddProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <!-- START MOBILE MENU AREA -->
        <div class="mobile-menu-area d-block d-lg-none section">
            <div class="container">
                <div class="row">
                    <div class="col-lg-12">
                        <div class="mobile-menu">
                            <nav id="dropdown">
                                <ul>
                                    <li><a href="index.html">Home</a>
                                        <ul>
                                            <li>
                                                <a href="index.html">Home Version 1</a>
                                            </li>
                                            <li>
                                                <a href="index-2.html">Home Version 2</a>
                                            </li>
                                            <li>
                                                <a href="index-3.html">Home Version 3</a>
                                            </li>
                                            <li>
                                                <a href="index-4.html">Home 4 Animated Text</a>
                                            </li>
                                            <li>
                                                <a href="index-5.html">Home 5 Animated Text Ovlerlay</a>
                                            </li>
                                            <li>
                                                <a href="index-6.html">Home 6 Background Video</a>
                                            </li>
                                            <li>
                                                <a href="index-7.html">Home 7 BG-Video Ovlerlay</a>
                                            </li>
                                            <li>
                                                <a href="index-8.html">Home 8 Boxed-1</a>
                                            </li>
                                            <li>
                                                <a href="index-9.html">Home 9 Gradient</a>
                                            </li>
                                            <li>
                                                <a href="index-10.html">Home 10 Boxed-2</a>
                                            </li>
                                        </ul>
                                    </li>
                                    <li>
                                        <a href="shop.html">Products</a>
                                    </li>
                                    <li><a href="#">Pages</a>
                                        <ul>
                                            <li>
                                                <a href="shop.html">Shop</a>
                                            </li>
                                            <li>
                                                <a href="shop-left-sidebar.html">Shop Left Sidebar</a>
                                            </li>
                                            <li>
                                                <a href="shop-right-sidebar.html">Shop Right Sidebar</a>
                                            </li>
                                            <li>
                                                <a href="shop-list.html">Shop List</a>
                                            </li>
                                            <li>
                                                <a href="shop-list-right-sidebar.html">Shop List Right Sidebar</a>
                                            </li>
                                            <li>
                                                <a href="single-product.html">Single Product</a>
                                            </li>
                                            <li>
                                                <a href="single-product-left-sidebar.html">Single Product Left Sidebar</a>
                                            </li>
                                            <li>
                                                <a href="single-product-no-sidebar.html">Single Product No Sidebar</a>
                                            </li>
                                            <li>
                                                <a href="cart.html">Shopping Cart</a>
                                            </li>
                                            <li>
                                                <a href="wishlist.html">Wishlist</a>
                                            </li>
                                            <li>
                                                <a href="checkout.html">Checkout</a>
                                            </li>
                                            <li>
                                                <a href="order.html">Order</a>
                                            </li>
                                            <li>
                                                <a href="login.html">Login</a>
                                            </li>
                                            <li>
                                                <a href="my-account-2.html">My Account</a>
                                            </li>
                                            <li>
                                                <a href="about.html">About us</a>
                                            </li>
                                            <li>
                                                <a href="404.html">404</a>
                                            </li>
                                        </ul>
                                    </li>
                                    <li><a href="blog.html">Blog</a>
                                        <ul>
                                            <li>
                                                <a href="blog.html">Blog</a>
                                            </li>
                                            <li>
                                                <a href="blog-left-sidebar.html">Blog Left Sidebar</a>
                                            </li>
                                            <li>
                                                <a href="blog-right-sidebar.html">Blog Right Sidebar</a>
                                            </li>
                                            <li>
                                                <a href="blog-2.html">Blog style 2</a>
                                            </li>
                                            <li>
                                                <a href="blog-2-left-sidebar.html">Blog 2 Left Sidebar</a>
                                            </li>
                                            <li>
                                                <a href="blog-2-right-sidebar.html">Blog 2 Right Sidebar</a>
                                            </li>
                                            <li>
                                                <a href="single-blog.html">Blog Details</a>
                                            </li>
                                        </ul>
                                    </li>
                                    <li>
                                        <a href="about.html">About Us</a>
                                    </li>
                                    <li>
                                        <a href="contact.html">Contact</a>
                                    </li>
                                </ul>
                            </nav>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- END MOBILE MENU AREA -->

        <!-- BREADCRUMBS SETCTION START -->
        <div class="breadcrumbs-section plr-200 mb-80 section">
            <div class="breadcrumbs overlay-bg">
                <div class="container">
                    <div class="row">
                        <div class="col-lg-12">
                            <div class="breadcrumbs-inner">
                                <h1 class="breadcrumbs-title">Add Product</h1>
                                <ul class="breadcrumb-list">
                                    <li><a href="index.html">Home</a></li>
                                    <li>Add Product</li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- BREADCRUMBS SETCTION END -->

        <!-- Start page content -->
        <div id="page-content" class="page-wrapper section">

            <!-- LOGIN SECTION START -->
            <div class="login-section mb-80">
                <div class="container">
                    <div class="row">
                        <center>
                        <!-- new-customers -->
                        <div class="col-lg-6">
                            <div class="new-customers">
                                
                                    <h6 class="widget-title border-left mb-50">Add Product </h6>
                                    <div class="login-account p-30 box-shadow">
                                        <div class="row">
                                            <!--<div class="col-sm-6">-->
                                                <!--<input type="text"  placeholder="First Name">-->
                                                <asp:TextBox ID="txtMobileName" runat="server" placeholder="Mobile Name"></asp:TextBox>
                                                
                                            <!--</div>-->
                                            <!--<div class="col-sm-6">-->
                                                <!--<input type="text"  placeholder="last Name">-->
                                                <asp:TextBox ID="txtPrice" runat="server" placeholder="Price"></asp:TextBox>
                                                
                                            
                                        <asp:TextBox ID="txtDiscount" runat="server" placeholder="Discount"></asp:TextBox>
                                        
                                        <!--<input type="password"  placeholder="Password">-->
                                        <asp:TextBox ID="txtDescription" runat="server" placeholder="Description"></asp:TextBox>
                                       
                                        <asp:TextBox ID="txtColor" runat="server" placeholder="Color"></asp:TextBox>
                                        
                                        
                                        <!--<input type="password"  placeholder="Confirm Password">-->
                                        <asp:TextBox ID="txtStorage" runat="server" placeholder="Storage"></asp:TextBox>
                                        

                                        <asp:TextBox ID="txtQuantity" runat="server" placeholder="Quantity"></asp:TextBox>
                                        

                                        &nbsp;&nbsp;&nbsp;&nbsp;Mobile Image :
                                        <asp:FileUpload ID="fldimg" runat="server" />
                                        <asp:Label ID="lblImageMessage" runat="server" ForeColor="Red" Visible="false"></asp:Label>
                                        
                                        <div>
                                            <div>
                                                <asp:Button ID="btnAddProduct" runat="server" Text="Add Product" class="submit-btn-1 mt-20 btn-hover-1" OnClick="btnAddProduct_Click"/>
                                            </div>
                                            
                                            <asp:Label ID="lblresponse" runat="server" Text="Label" Visible="False"></asp:Label>
                                            <!--<asp:Label ID="lblerror" runat="server" Text="Label" Visible="False"></asp:Label>-->
                                            
                                        </div>
                                    </div>
                                
                            </div>
                        </div>
                    </div>
                            </center>
                </div>
            </div>
            <!-- LOGIN SECTION END -->             

        </div>
        <!-- End page content -->
    </div>
</asp:Content>

