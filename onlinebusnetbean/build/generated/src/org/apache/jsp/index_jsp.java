package org.apache.jsp;

import javax.servlet.*;
import javax.servlet.http.*;
import javax.servlet.jsp.*;
import com.onlinebus.beans.MemberBean;

public final class index_jsp extends org.apache.jasper.runtime.HttpJspBase
    implements org.apache.jasper.runtime.JspSourceDependent {

  private static final JspFactory _jspxFactory = JspFactory.getDefaultFactory();

  private static java.util.List<String> _jspx_dependants;

  static {
    _jspx_dependants = new java.util.ArrayList<String>(2);
    _jspx_dependants.add("/header.jsp");
    _jspx_dependants.add("/footer.jsp");
  }

  private org.glassfish.jsp.api.ResourceInjector _jspx_resourceInjector;

  public java.util.List<String> getDependants() {
    return _jspx_dependants;
  }

  public void _jspService(HttpServletRequest request, HttpServletResponse response)
        throws java.io.IOException, ServletException {

    PageContext pageContext = null;
    HttpSession session = null;
    ServletContext application = null;
    ServletConfig config = null;
    JspWriter out = null;
    Object page = this;
    JspWriter _jspx_out = null;
    PageContext _jspx_page_context = null;

    try {
      response.setContentType("text/html");
      pageContext = _jspxFactory.getPageContext(this, request, response,
      			null, true, 8192, true);
      _jspx_page_context = pageContext;
      application = pageContext.getServletContext();
      config = pageContext.getServletConfig();
      session = pageContext.getSession();
      out = pageContext.getOut();
      _jspx_out = out;
      _jspx_resourceInjector = (org.glassfish.jsp.api.ResourceInjector) application.getAttribute("com.sun.appserv.jsp.resource.injector");

      out.write("<!DOCTYPE html>\n");
      out.write("<html>\n");
      out.write("<head>\n");
      out.write("<meta http-equiv=\"Content-Type\" content=\"text/html; charset=ISO-8859-1\">\n");
      out.write("<script type=\"text/javascript\" src=\"");
      out.print(request.getContextPath());
      out.write("/js/jquery-1.10.2.min.js\"></script>\n");
      out.write("<script type=\"text/javascript\">\n");
      out.write("$(document).ready(function()\n");
      out.write("{\n");
      out.write("\n");
      out.write(" $(\"#datepicker\").datepicker(\n");
      out.write(" \t{\n");
      out.write("\t\tminDate: 0,\n");
      out.write("\t\tchangeMonth: true,\n");
      out.write("\t\tchangeYear: true,\n");
      out.write("\t\tdateFormat:\"yy-mm-dd\",\n");
      out.write("\t    setDate: new Date()   \n");
      out.write("\t});\n");
      out.write("\t$(\"#datepicker\").datepicker(\"setDate\", new Date());\n");
      out.write("});\n");
      out.write("\n");
      out.write("</script>\n");
      out.write("\n");
      out.write("<title>Bus Reservation</title>\n");
      out.write("</head>\n");
      out.write("<body>\n");
      out.write("<div class=\"headerdiv\">\n");
      out.write("\n");
      out.write("\n");
      out.write("\n");
      out.write("<!DOCTYPE html>\n");
      out.write("\n");
      out.write("\n");
      out.write("\n");
      out.write("<link rel=\"stylesheet\" type=\"text/css\" href=\"");
      out.print(request.getContextPath());
      out.write("/css/jquery-datepicker.css\">\n");
      out.write("<link rel=\"stylesheet\" type=\"text/css\" href=\"");
      out.print(request.getContextPath());
      out.write("/css/header.css\">\n");
      out.write("<link rel=\"stylesheet\" type=\"text/css\" href=\"");
      out.print(request.getContextPath());
      out.write("/css/index.css\">\n");
      out.write("<link rel=\"stylesheet\" type=\"text/css\" href=\"");
      out.print(request.getContextPath());
      out.write("/css/loadAvailableBuses.css\">\n");
      out.write("<link rel=\"stylesheet\" type=\"text/css\" href=\"");
      out.print(request.getContextPath());
      out.write("/css/admincss.css\">\n");
      out.write("\n");
      out.write("<script type=\"text/javascript\" src=\"");
      out.print(request.getContextPath());
      out.write("/js/jquery-1.10.2.min.js\"></script>\n");
      out.write("<script type=\"text/javascript\" src=\"");
      out.print(request.getContextPath());
      out.write("/js/jquery-ui.js\"></script>\n");
      out.write("<script type=\"text/javascript\" src=\"");
      out.print(request.getContextPath());
      out.write("/js/header.js\"></script>\n");
      out.write("<script type=\"text/javascript\" src=\"");
      out.print(request.getContextPath());
      out.write("/js/register.js\"></script>\n");
      out.write("<script type=\"text/javascript\" src=\"");
      out.print(request.getContextPath());
      out.write("/js/login.js\"></script>\n");
      out.write("<script type=\"text/javascript\"> var path =\"");
      out.print(request.getContextPath());
      out.write("\";</script>\n");
      out.write("<script type=\"text/javascript\" src=\"");
      out.print(request.getContextPath());
      out.write("/js/index.js\"></script>\n");
      out.write("<script type=\"text/javascript\" src=\"");
      out.print(request.getContextPath());
      out.write("/js/ticketcancellation.js\"></script>\n");
      out.write("\n");
      out.write("<div class=\"wrapperheader\">\n");
      out.write("\t<div class=\"topheader\">\n");
      out.write("\t\t<div class=\"logoheader\">\n");
      out.write("\t\t\t<a href =\"");
      out.print(request.getContextPath());
      out.write("\"><img src=\"");
      out.print(request.getContextPath() );
      out.write("/images/logo.png\" style =\"height:80px;width:160px;\"></a>\n");
      out.write("\t\t</div>");
      out.write("<div class=\"clear\"></div>\n");
      out.write("\t</div>\n");
      out.write("\t\n");
      out.write("\t<div class=\"downheader\">\n");
      out.write("\t\t<div class=\"leftlinks\">\n");
      out.write("\t\t\t<a href =\"");
      out.print(request.getContextPath());
      out.write("\">HOME</a>\n");
      out.write("\t\t\t\n");
      out.write("\t\t\t\n");
      out.write("\t\t\t<div class=\"clear\"></div>\n");
      out.write("\t\t</div>\n");
      out.write("\t\t\n");
      out.write("\t\t<div class=\"rightlinks\">\n");
      out.write("\t\t\t");

			MemberBean memberBean = (MemberBean)request.getSession().getAttribute("MemberBean");
			if(memberBean == null)
			{
      out.write("\n");
      out.write("\t\t\t\t<span> Hi Guest</span>\n");
      out.write("\t\t\t");
}else{
      out.write("\n");
      out.write("\t\t\t \t<span style=\"color:blue; font: italic;\"> Hi ");
      out.print(memberBean.getMemberFirstname());
      out.write("</span>\n");
      out.write("\t\t\t \t<script type=\"text/javascript\">loginFlag=true;</script>\n");
      out.write("\t\t\t");
}
      out.write("\n");
      out.write("\t\t\t\n");
      out.write("\t\t\t");
if(memberBean == null)
			{
      out.write("\n");
      out.write("\t\t\t\t<a href=\"javascript:void(0);\" onClick=\"headerObj.login_popup();\">LOGIN</a>\n");
      out.write("\t\t\t\t<a href=\"javascript:void(0);\"  onClick=\"headerObj.register_popup();\">REGISTER</a>\n");
      out.write("\t\t\t");
}else{ 
      out.write("\n");
      out.write("\t\t\t\t<a href=\"");
      out.print(request.getContextPath());
      out.write("/jsp/myAccount.jsp\">MyAccount</a>\n");
      out.write("\t\t\t\t<a href=\"");
      out.print(request.getContextPath());
      out.write("/jsp/ticketcancellation.jsp\">Cancellation</a>\n");
      out.write("\t\t\t\t<a href=\"");
      out.print(request.getContextPath());
      out.write("/jsp/logout.jsp\"  >Signout</a>\n");
      out.write("\t\t\t");
} 
      out.write("\n");
      out.write("\t\t\t<div class=\"clear\"></div>\n");
      out.write("\t\t</div>\n");
      out.write("\t</div>\n");
      out.write("\n");
      out.write("</div>\n");
      out.write("\n");
      out.write("<div id=\"background\">\n");
      out.write("</div>\n");
      out.write("\t<div id=\"registerbox\">\n");
      out.write("\t\t<div align=\"center\" style=\"font-size:16px; font-weight:bold;\">\n");
      out.write("\t\t\tRegister Here\n");
      out.write("\t\t</div><br>\n");
      out.write("\t\t<div id=\"validationall\" style=\"border-style: solid;\">\n");
      out.write("\t\t\t\n");
      out.write("\t\t</div><br>\n");
      out.write("\t\t\n");
      out.write("\t\t<div align=\"left\">\n");
      out.write("\t\t\tEmail Address:\n");
      out.write("\t\t</div>\n");
      out.write("\t\t<div align=\"left\">\n");
      out.write("\t\t\t<input type=\"text\" id=\"email\" name=\"email\"  class=\"inputBox\"  onblur=\"registrObj.emailAvailable(this.value);\">\n");
      out.write("\t\t</div><br>\n");
      out.write("\t\t\n");
      out.write("\t\t<div align=\"left\">\n");
      out.write("\t\t\tFirst Name:\n");
      out.write("\t\t</div>\n");
      out.write("\t\t<div align=\"left\">\n");
      out.write("\t\t\t<input type=\"text\" id=\"name\" name=\"name\" class=\"inputBox\" >\n");
      out.write("\t\t</div><br>\n");
      out.write("\n");
      out.write("\t\t<div align=\"left\">\n");
      out.write("\t\t\tLast Name:\n");
      out.write("\t\t</div>\n");
      out.write("\t\t<div align=\"left\">\n");
      out.write("\t\t\t<input type=\"text\" id=\"lastname\" name=\"lastname\" class=\"inputBox\">\n");
      out.write("\t\t</div><br>\n");
      out.write("\t\t\t\t\t\t\n");
      out.write("\t\t<div align=\"left\">\n");
      out.write("\t\t\tMobile Number:\n");
      out.write("\t\t</div>\n");
      out.write("\t\t<div align=\"left\">\n");
      out.write("\t\t\t<input type=\"text\" id=\"mobileno\" name=\"mobileno\"  class=\"inputBox\">\n");
      out.write("\t\t</div><br>\n");
      out.write("\n");
      out.write("\t\t<div align=\"left\">\n");
      out.write("\t\t\tAddress\n");
      out.write("\t\t</div>\n");
      out.write("\t\t<div align=\"left\">\n");
      out.write("\t\t\t<input type=\"text\" id=\"address\" name=\"address\"  class=\"inputBox\" >\n");
      out.write("\t\t</div><br>\n");
      out.write("\t\t\t\t\n");
      out.write("\t\t<div align=\"left\">\n");
      out.write("\t\t\tYour Password:\n");
      out.write("\t\t</div>\n");
      out.write("\t\t<div align=\"left\">\n");
      out.write("\t\t\t<input type=\"password\" id=\"password\" name=\"password\"  value=\"\" class=\"inputBox\">\n");
      out.write("\t\t</div><br>\n");
      out.write("\t\t\t\t\n");
      out.write("\t\t<div align=\"left\">\n");
      out.write("\t\t\tConfirm Password:\n");
      out.write("\t\t</div>\n");
      out.write("\t\t<div align=\"left\">\n");
      out.write("\t\t\t<input type=\"password\" id=\"confirmpassword\" name=\"confirmpassword\" class=\"inputBox\">\n");
      out.write("\t\t</div><br>\n");
      out.write("\t\t\t\t\n");
      out.write("\t\t<div align=\"left\">\n");
      out.write("\t\t\t<a href=\"javascript:void(0);\" class=\"button_style\" id=\"submit\" onclick=\"return registrObj.checkValidation();\">REGISTER</a>\n");
      out.write("\t\t\t<a href=\"javascript:void(0);\" class=\"button_style\" onClick=\"headerObj.popup_cancel();\">CANCEL</a>\n");
      out.write("\t\t</div>\n");
      out.write("\t</div>");
      out.write("\n");
      out.write("\t\t\t\n");
      out.write("\t<div id=\"loginbox\">\n");
      out.write("\t\t<div>\n");
      out.write("\t\t\tLOGIN \n");
      out.write("\t\t</div><br/>\n");
      out.write("\t\t<div id=\"signin_error_message\">\n");
      out.write("\t\t\t<span id=\"login_error_msg\" style=\"color:red\"></span>\t\n");
      out.write("\t\t</div><br/>\n");
      out.write("\n");
      out.write("\t\t<div align=\"left\">\n");
      out.write("\t\t\tEmail Id:\n");
      out.write("\t\t</div>\n");
      out.write("\t\t<div align=\"left\">\n");
      out.write("\t\t\t<input type=\"text\" id=\"login_email\" name=\"login_email\" maxlength=\"50\" class=\"inputBox\">\n");
      out.write("\t\t</div><br/>\n");
      out.write("\t\t\t\t\n");
      out.write("\t\t<div align=\"left\">\n");
      out.write("\t\t\tPassword:\n");
      out.write("\t\t</div>\n");
      out.write("\t\t<div align=\"left\">\n");
      out.write("\t\t\t<input type=\"password\" id=\"login_password\" name=\"login_password\" maxlength=\"50\" class=\"inputBox\">\n");
      out.write("\t\t</div><br/>\n");
      out.write("\n");
      out.write("\t\t<div align=\"left\">\n");
      out.write("\t\t\t<a href=\"javascript:void(0);\" class=\"button_style\"  onClick=\"return loginObj.check_login_validation();\">LOGIN</a>\n");
      out.write("\t\t\t<a href=\"javascript:void(0);\" class=\"button_style\"  onClick=\"headerObj.popup_cancel();\">CANCEL</a>\n");
      out.write("\t\t\t<a href=\"javascript:void(0);\" onclick=\"headerObj.popupOpenRegister();\">register now</a>\n");
      out.write("\t\t</div>\n");
      out.write("\t\t\n");
      out.write("\t\t\n");
      out.write("\t\t\n");
      out.write("\t</div>\n");
      out.write("\t\t\t\n");
      out.write("\t");
      out.write("\n");
      out.write("</div>\n");
      out.write("\n");
      out.write("<div class=\"contentdiv\">\n");

String status = request.getParameter("status");

if("fail".equals(status)){
status = "Some Error Occured during  process";
}
else
status = "";

      out.write("\n");
      out.write("<div>\n");
      out.print(status);
      out.write("\n");
      out.write("</div>\n");
      out.write("\n");
      out.write("\t<div class=\"routeSearchMain\">\n");
      out.write("\t\t<div class=\"cmnSearch\">\n");
      out.write("\t\t<div class=\"errordiv\" id =\"errordiv\"></div>\n");
      out.write("\t\t\t<div class=\"searchLft\">\n");
      out.write("\t\t\t\t<span class=\"blackText\">From</span><span style= \"color:red\">*</span>\n");
      out.write("\t\t\t\t<form action=\"");
      out.print(request.getContextPath());
      out.write("/jsp/loadAvailableBuses.jsp\" method=\"post\">\n");
      out.write("\t\t\t\t<input id=\"DDLSource\"  placeholder=\"Enter a city\" type=\"text\" tabindex=\"1\"  name=\"DDLSource\"  onkeyup=\"indexObj.search_from_city();\" maxlength=\"20\" >\n");
      out.write("\t\t\t</div>\n");
      out.write("\t\t\t\n");
      out.write("\t\t\t<div class=\"searchRht\">\n");
      out.write("\t\t\t\t<span class=\"blackText\">To</span><span style= \"color:red\">*</span>\n");
      out.write("\t\t\t\t<input id=\"DDLDestination\" placeholder=\"Enter a city\" type=\"text\" tabindex=\"2\" name=\"DDLDestination\" onkeyup=\"indexObj.search_to_city();\" maxlength=\"20\">\n");
      out.write("\t\t\t</div>\n");
      out.write("\t\t</div><!-- cmnsearch close -->\n");
      out.write("\t\t\n");
      out.write("\t\t\n");
      out.write("\t\t<div class=\"btmRow\">\n");
      out.write("\t\t\t<div class=\"searchLft\">\n");
      out.write("\t\t\t\t<span class=\"blackText\">Date of Journey</span>\n");
      out.write("\t\t\t\t\t<input id=\"datepicker\" name=\"datepicker\" placeholder=\"yyyy-mm-dd\" type=\"text\" tabindex=\"3\" readonly=\"readonly\" class=\"datepicker\">\n");
      out.write("\t\t\t\t\t\n");
      out.write("\t\t\t\t\t\n");
      out.write("\t\t\t</div>               \n");
      out.write("\t\t</div><br><br><br><br><br><br>\n");
      out.write("\t\t<div class=\"seatcount_bustypediv\">\n");
      out.write("\t\t\t<span class=\"blackText\">Seat Count</span>&nbsp;&nbsp;&nbsp;\n");
      out.write("\t\t\t<input id=\"SeatCount\" placeholder=\"Enter seat count\" type=\"text\" tabindex=\"4\"  name=\"seatCount\" maxlength=\"2\">\n");
      out.write("\t\t\t<br><br>\n");
      out.write("\t\t\t<span class=\"blackText\">Bus Type</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;\n");
      out.write("\t\t\t\n");
      out.write("\t\t\t<select style=\"width:120px;\" tabindex=\"5\" name=\"bus_type\" id=\"bus_type\">\n");
      out.write("\t\t\t  <option value=\"SELECT\">SELECT</option>\n");
      out.write("\t\t\t  <option value=\"A/C-Sleeper\">A/C-Sleeper</option>\n");
      out.write("\t\t\t  <option value=\"A/C-Non-Sleeper\">A/C-Non-Sleeper</option>\n");
      out.write("\t\t\t  <option value=\"NON A/C-Sleeper\">NON A/C-Sleeper</option>\n");
      out.write("\t\t\t  <option value=\"NON A/C-Non-Sleeper\">NON A/C-Non-Sleeper</option>\n");
      out.write("\t\t\t</select>\n");
      out.write("\t\t\t\n");
      out.write("\t\t</div>\n");
      out.write("\t\t\t\n");
      out.write("\t\t<input type=\"hidden\" value=\"loadAllBuses\" name=\"pageType\">\n");
      out.write("\t\t<div class=\"searchbuttonbox\">\n");
      out.write("\t\t\n");
      out.write("\t\t\t<input type=\"submit\" value=\" Search Buses \" class=\"searchBtn\" onclick=\"return indexObj.isCityEqual();\" id=\"searchBtn\" name=\"searchBtn\" tabindex=\"6\" style=\"margin-top:0;\">\n");
      out.write("\t\t\t\n");
      out.write("\t\t</div>\n");
      out.write("\t\t</form>\n");
      out.write("\t\n");
      out.write("\t</div>\n");
      out.write("\n");
      out.write("</div>\n");
      out.write("\n");
      out.write("<div class=\"footerdiv\">\n");
      out.write("<link rel=\"stylesheet\" type=\"text/css\" href=\"");
      out.print(request.getContextPath());
      out.write("/css/footer.css\">\n");
      out.write("\t<div class=\"footer\">\n");
      out.write("\t\t<hr style=\"height:2px;\">\n");
      out.write("\t\t<div class=\"footerimage\">\n");
      out.write("\t\t\t<a href =\"");
      out.print(request.getContextPath());
      out.write("\"><img src=\"");
      out.print(request.getContextPath() );
      out.write("/images/footerlogo.png\" style=\"position:absolute; border: none;\"></a>\n");
      out.write("\t\t</div>\n");
      out.write("\t\t<div class=\"footerlinks\">\n");
      out.write("\t\t\t<a href=");
      out.print(request.getContextPath());
      out.write(">HOME</a>\n");
      out.write("\t\t\t<a href=\"javascript:void(0);\">AboutUs</a>\n");
      out.write("\t\t\t<a href=\"javascript:void(0);\">ContactUs</a>\n");
      out.write("\t\t\t<div class=\"clear\"></div>\n");
      out.write("\t\t</div>\n");
      out.write("\t</div>\n");
      out.write("\n");
      out.write("\n");
      out.write("</div>\n");
      out.write("\n");
      out.write("</body>\n");
      out.write("</html>");
    } catch (Throwable t) {
      if (!(t instanceof SkipPageException)){
        out = _jspx_out;
        if (out != null && out.getBufferSize() != 0)
          out.clearBuffer();
        if (_jspx_page_context != null) _jspx_page_context.handlePageException(t);
        else throw new ServletException(t);
      }
    } finally {
      _jspxFactory.releasePageContext(_jspx_page_context);
    }
  }
}
