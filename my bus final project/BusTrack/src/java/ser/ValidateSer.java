/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package ser;

import DB.LogDB;
import ModelClass.LogBean;
import java.io.IOException;
import java.io.PrintWriter;
import javax.servlet.ServletException;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

/**
 *
 * @author ind
 */
public class ValidateSer extends HttpServlet {
   
    /** 
     * Processes requests for both HTTP <code>GET</code> and <code>POST</code> methods.
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    static public int counter_log=0;
    protected void processRequest(HttpServletRequest request, HttpServletResponse response)
    throws ServletException, IOException {
        response.setContentType("text/html;charset=UTF-8");
        PrintWriter out = response.getWriter();
        try {
            /* TODO output your page here
            out.println("<html>");
            out.println("<head>");
            out.println("<title>Servlet ValidateSer</title>");  
            out.printltn("</head>");
            out.println("<body>");
            out.println("<h1>Servlet ValidateSer at " + request.getContextPath () + "</h1>");
            out.println("</body>");
            out.println("</html>");
            */
            boolean check=false;
            HttpSession session=request.getSession();
            String username=request.getParameter("username");
            String password=request.getParameter("password");
            out.println("username "+username);
            LogDB log_db=new LogDB();
            check=log_db.verify(username,password);
            if(check){
                LogBean logbean=log_db.getUserDetail(username,password);
                session.setAttribute("userid",username);
                session.setAttribute("user_city",logbean.getCity());
                session.setAttribute("user_Name",logbean.getName());
                session.setAttribute("user_emailid",logbean.getEmailID());
                session.setAttribute("Check_Tag","check");
                int tag_value=logbean.getTag();
                //System.out.println(" tag_value "+tag_value);

                if(tag_value==1){
                    ////adin
                    counter_log=1;
                    response.sendRedirect("New_Bus.jsp");

                }else if(tag_value==2){
                    ////agent
                    counter_log=1;
                    response.sendRedirect("My_agent.jsp");
                }else{
                    ////client
                    counter_log=1;
                   response.sendRedirect("My_agent.jsp");
                }


               // response.sendRedirect("");
            }else {
                counter_log=1;
                 session.setAttribute("Error_Login","Incorrect username and password");
                 response.sendRedirect("Login.jsp");
            }


        } finally { 
            out.close();
        }
    } 

    // <editor-fold defaultstate="collapsed" desc="HttpServlet methods. Click on the + sign on the left to edit the code.">
    /** 
     * Handles the HTTP <code>GET</code> method.
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doGet(HttpServletRequest request, HttpServletResponse response)
    throws ServletException, IOException {
        processRequest(request, response);
    } 

    /** 
     * Handles the HTTP <code>POST</code> method.
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    @Override
    protected void doPost(HttpServletRequest request, HttpServletResponse response)
    throws ServletException, IOException {
        processRequest(request, response);
    }

    /** 
     * Returns a short description of the servlet.
     * @return a String containing servlet description
     */
    @Override
    public String getServletInfo() {
        return "Short description";
    }// </editor-fold>

}
