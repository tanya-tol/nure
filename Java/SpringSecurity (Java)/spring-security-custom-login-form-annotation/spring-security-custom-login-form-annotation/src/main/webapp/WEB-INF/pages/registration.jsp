<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<html>
<head>
  <title> Admin portal </title>
</head>
<body>

<c:url value="/registration" var="registrationUrl" />
<form action="${registrationUrl}" method="post" id="registrationForm">
  <input type="hidden" name="${_csrf.parameterName}"
         value="${_csrf.token}" />
</form>

<c:if test="${pageContext.request.userPrincipal.name = null}">
  <table align="center">
    <tr>
      <td><strong>Role</strong></td>
      <td><p><select size="2" multiple name="hero[]">
        <option value="admin">ROLE_ADMIN</option>
        <option value="user">ROLE_USER</option>
      </select></p><td>
    </tr>
    <tr>
      <td ><strong>E-mail:</strong></td>
      <td><input type="mail" class="text" style="width : 140px;" name=email></td>
    </tr>
    <tr>
      <td ><strong>Password:</strong></td>
      <td><input type="password" class="text" style="width : 140px;" name=pass></td>
    </tr>
    <tr>
      <td align="center"><a href="login.jsp"><input type="submit" value="Sign up"></a></td>
    </tr>
  </table>
</c:if>
</body>
</html>