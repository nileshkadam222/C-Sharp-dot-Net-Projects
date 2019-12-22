/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package ser;

import DB.VisitDB;
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
public class Visit_Ser extends HttpServlet {
   
    /** 
     * Processes requests for both HTTP <code>GET</code> and <code>POST</code> methods.
     * @param request servlet request
     * @param response servlet response
     * @throws ServletException if a servlet-specific error occurs
     * @throws IOException if an I/O error occurs
     */
    protected void service(HttpServletRequest request, HttpServletResponse response)
    throws ServletException, IOException {
        response.setContentType("text/html;charset=UTF-8");
        PrintWriter out = response.getWriter();
         LogBean logbean=new LogBean();
         int counter=0;
          VisitDB log_db=new VisitDB();
        try {
           HttpSession session=request.getSession();
           String content=request.getParameter("do");
           if("login".equals(content)){
               String username=request.getParameter("username");
               String pass=request.getParameter("password");
                String bus_no=request.getParameter("busno");
               String dest=request.getParameter("destination");
                boolean check=false;


           
            check=log_db.verify(username,pass);
            if(check){
                logbean=log_db.getUserDetail(username,pass);
                session.setAttribute("userid_new",username);
                session.setAttribute("user_city_new",logbean.getCity());
                session.setAttribute("user_Name_new",logbean.getName());
                session.setAttribute("user_emailid_new",logbean.getEmailID());
                session.setAttribute("Check_Tag_new","check");
                int tag_value=logbean.getTag();
                session.setAttribute("bus_sign",bus_no);
                session.setAttribute("dest_sign",dest);
                //System.out.println(" tag_value "+tag_value);
                 response.sendRedirect("seat_Allocation_log.jsp");

           }
            }///if
          else if("signup".equals(content)){
                     String usr_name=request.getParameter("user_name");
                     String username=request.getParameter("user");
                     String pass=request.getParameter("password");
                     String user_city=request.getParameter("city");
                     String email_id=request.getParameter("email");

                     logbean.setName(usr_name);
                     logbean.setUser(username);
                     logbean.setPass(pass);
                     logbean.setCity(user_city);
                     logbean.setEmailID(email_id);
                     counter=log_db.Signup(logbean);
                     if(counter==2){
                         session.setAttribute("userid_visit_sign",username);
                         session.setAttribute("username_visit_sign",usr_name);
                           session.setAttribute("ADD_SIGNUP","Data insert successfully.");
                     }
                    
                     response.sendRedirect("seat_alloc_sign.jsp");
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
   
}
