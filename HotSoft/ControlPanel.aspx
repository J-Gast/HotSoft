<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ControlPanel.aspx.cs" Inherits="HotSoft.ControlPanel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0"/>
     <link rel ="stylesheet" href="StyleControlPanel.css" type="text/css" media="screen" />
 

    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 60;
        }
    </style>
</head>
<body>
     <header class="Encabezado">
       <img src="Images/oie_transparent.png" />
         
    </header>
    <form id="form1" runat="server">
        <div>
            <div class="FormsGroup">
                <div class="FormProgramador">
                    <h1>Programador requerido</h1>
                    <br />
                    <div class="ContSlider">
                         <h3>Asigne un valor para este criterio</h3>
                         <input id="RangeProgCriterio" type="range" runat="server" min="1" max="100" oninput="document.getElementById('lblRangeCriterio').textContent = this.value;"  />
                          <asp:Label ID="lblRangeCriterio" runat="server" Text="50" ForeColor="#329040"></asp:Label>
                    </div>
                    <table style="width: 92%;">
                        <tr>
                            <td><%--<asp:RadioButton ID="RbJr" runat="server" Text="Junior" CssClass="Rbtn" GroupName="A" />--%>
                                 <div class="ContSlider">
                                     <h3>Asigne valor para programador Junior</h3>
                                     <input id="RangeJunior" type="range" runat="server" min="1" max="100" oninput="document.getElementById('lblJunior').textContent = this.value;"  />
                                     <asp:Label ID="lblJunior" runat="server" ForeColor="#329040">50</asp:Label>
                               </div>
                             </td>
                        </tr>
                        <tr>
                            <td>  <%--<asp:RadioButton ID="RbMdd" runat="server" Text="Middle" CssClass="Rbtn" GroupName="A" />--%>
                                <div class="ContSlider">
                                     <h3>Asigne valor para programador Middle</h3>
                                     <input id="RangeMiddle" type="range" runat="server" min="1" max="100" oninput="document.getElementById('lblMiddle').textContent = this.value;"  />
                                    <asp:Label ID="lblMiddle" runat="server" Text="50" ForeColor="#329040"></asp:Label>
                               </div>
                            </td> 
                        </tr>
                        <tr>
                              <td> <%--<asp:RadioButton ID="RbSr" runat="server" Text="Senior" CssClass="Rbtn" GroupName="A" />--%>
                                   <div class="ContSlider">
                                         <h3>Asigne valor para programador Senior</h3>
                                         <input id="RangeSenior" type="range" runat="server" min="1" max="100" oninput="document.getElementById('lblSenior').textContent = this.value;"  />
                                        <asp:Label ID="lblSenior" runat="server" Text="50" ForeColor="#329040"></asp:Label>
                                   </div>
                              </td>
                        </tr>
                    </table>
                    <br />
                </div>

            <div class="FormEstudios">
                <div class="FormGroup">
                    <h1>Grado de estudios</h1>
                    <br />
                      <div class="ContSlider">
                            <h3>Asigne un valor para este criterio</h3>
                            <input id="Range2" type="range" runat="server" min="1" max="100" oninput="document.getElementById('Label2').textContent = this.value;"  />
                             <asp:Label ID="Label2" runat="server" Text="50" ForeColor="#329040"></asp:Label>
                      </div>
                    <table style="width: 93%;">
                        <tr>
                            <td>
                                <div class="Radio">
                                      <input id="rbLicenciatura" runat="server" type="radio" name="Estudios" />
                                      <label for="rbLicenciatura">Licenciatura</label>
                                </div>
                            </td>
                            <td>
                                <div class="Radio">
                                      <input id="rbMaestria" runat="server" type="radio" name="Estudios" />
                                      <label for="rbMaestria">Maestria</label>
                                </div>
                            </td>
                            <td>
                                <div class="Radio">
                                      <input id="rbDoctorado" runat="server" type="radio" name="Estudios" />
                                      <label for="rbDoctorado">Doctorado</label>
                                </div>
                            </td>
                        </tr>
                    </table>
                    <br />
              
                    <asp:Label ID="Label1" runat="server" Text="Carrera afín" Font-Size="14pt"></asp:Label>
                    <br />

                    <asp:DropDownList ID="cbAfin" runat="server" CssClass="auto-style1" Height="53px" Width="291px">
                        <asp:ListItem>Programación general</asp:ListItem>
                        <asp:ListItem>Programación de redes</asp:ListItem>
                        <asp:ListItem>Programación electronica</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                </div>
            </div>

             <div class="FormCert">
                 <div class="FormGroup">
                      <h1>Habilidades</h1>
                      <div class="ContSlider">
                          <h3>Asigne un valor para este criterio</h3>
                          <input id="Range3" type="range" runat="server" min="1" max="100" oninput="document.getElementById('Label3').textContent = this.value;"  />
                          <asp:Label ID="Label3" runat="server" Text="50" ForeColor="#329040"></asp:Label>
                      </div>
                     <div class="checkbox">
                           <table style="width: 93%;">
                                <tr>
                                    <td class="auto-style4">
                                          <input id="ch1Cert" runat="server" type="checkbox" name="ch1Cert" />
                                          <label for="ch1Cert">Visual Basic</label>
                                    </td>
                                    <td class="auto-style5">
                                          <input id="ch2Cert" runat="server" type="checkbox" name="ch2Cert" />
                                          <label for="ch2Cert">C</label>
                                  
                                    </td>
                                    <td>
                                         <input id="ch3Cert" runat="server" type="checkbox" name="ch3Cert" />
                                         <label for="ch3Cert">C++</label>
                              
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                         <input id="ch4Cert" runat="server" type="checkbox" name="ch4Cert" />
                                         <label for="ch4Cert">Java</label>
                              
                                       
                                    </td>
                                    <td class="auto-style5">
                                         <input id="ch5Cert" runat="server" type="checkbox" name="ch5Cert" />
                                         <label for="ch5Cert">Python</label>
                                        
                                    </td>
                                    <td>
                                         <input id="ch6Cert" runat="server" type="checkbox" name="ch6Cert" />
                                         <label for="ch6Cert">Pascal</label>
                                       
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <input id="ch7Cert" runat="server" type="checkbox" name="ch7Cert" />
                                         <label for="ch7Cert">C#</label>
                                        
                                    </td>
                                    <td class="auto-style5">
                                         <input id="ch8Cert" runat="server" type="checkbox" name="ch8Cert" />
                                         <label for="ch8Cert">Ruby</label>
                                        
                                    </td>
                                    <td>
                                         <input id="ch9Cert" runat="server" type="checkbox" name="ch9Cert" />
                                         <label for="ch9Cert">PHP</label>
                                       
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                         <input id="ch10Cert" runat="server" type="checkbox" name="ch10Cert" />
                                         <label for="ch10Cert">HTML</label>
                                       
                                    </td>
                                    <td class="auto-style5">
                                         <input id="ch11Cert" runat="server" type="checkbox" name="ch11Cert" />
                                         <label for="ch11Cert">CSS</label>
                                        
                                    </td>
                                    <td>
                                         <input id="ch12Cert" runat="server" type="checkbox" name="ch12Cert" />
                                         <label for="ch12Cert">JavaScript</label>
                                        
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                          <input id="ch13Cert" runat="server" type="checkbox" name="ch13Cert" />
                                         <label for="ch13Cert">Ensamblador</label>
                                       
                                    </td>
                                    <td class="auto-style5">
                                        <input id="ch14Cert" runat="server" type="checkbox" name="ch14Cert" />
                                        <label for="ch14Cert">Fortran</label>
                                       
                                       
                                    </td>
                                    <td>
                                         <input id="ch15Cert" runat="server" type="checkbox" name="ch15Cert" />
                                         <label for="ch15Cert">COBOL</label>
                                        
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                         <input id="ch16Cert" runat="server" type="checkbox" name="ch16Cert" />
                                        <label for="ch16Cert">NesC</label>
                                       
                                    </td>
                                    <td class="auto-style5">
                                        <input id="ch17Cert" runat="server" type="checkbox" name="ch17Cert" />
                                        <label for="ch17Cert">Prolog</label>
                                       
                                    </td>
                                    <td>
                                        <input id="ch18Cert" runat="server" type="checkbox" name="ch18Cert" />
                                        <label for="ch18Cert">UML</label>
                                        
                                    </td>
                                </tr>
                            </table>
                         </div>
                  </div>
            </div>

            <div class="FormAptitud">
                <div class="FormGroup">
                      <h1>Aptitudes</h1>
                      <div class="ContSlider">
                          <h3>Asigne un valor para este criterio</h3>
                          <input id="Range4" type="range" runat="server" min="1" max="100" oninput="document.getElementById('Label4').textContent = this.value;"  />
                           <asp:Label ID="Label4" runat="server" Text="50" ForeColor="#329040"></asp:Label>
                      </div>
                      <div class="checkbox">
                              <table style="width: 93%;">
                                <tr>
                                    <td class="auto-style4">
                                          <input id="ch1Apt" runat="server" type="checkbox" name="ch1Apt" />
                                          <label for="ch1Apt">Trabajo en equipo</label>
                                    </td>
                                    <td class="auto-style5">
                                          <input id="ch2Apt" runat="server" type="checkbox" name="ch2Apt" />
                                          <label for="ch2Apt">Facilidad de palabra</label>
                                  
                                    </td>
                                    <td>
                                         <input id="ch3Apt" runat="server" type="checkbox" name="ch3Apt" />
                                         <label for="ch3Apt">Facilidad de aprendizaje</label>
                              
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                         <input id="ch4Apt" runat="server" type="checkbox" name="ch4Apt" />
                                         <label for="ch4Apt">Buena comunicación</label>
                              
                                       
                                    </td>
                                    <td class="auto-style5">
                                         <input id="ch5Apt" runat="server" type="checkbox" name="ch5Apt" />
                                         <label for="ch5Apt">Puntualidad</label>
                                        
                                    </td>
                                    <td>
                                         <input id="ch6Apt" runat="server" type="checkbox" name="ch6Apt" />
                                         <label for="ch6Apt">Bueno escuchando</label>
                                       
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <input id="ch7Apt" runat="server" type="checkbox" name="ch7Apt" />
                                         <label for="ch7Apt">Liderazgo</label>
                                        
                                    </td>
                                    <td class="auto-style5">
                                         <input id="ch8Apt" runat="server" type="checkbox" name="ch8Apt" />
                                         <label for="ch8Apt">Perseverancia</label>
                                        
                                    </td>
                                    <td>
                                         <input id="ch9Apt" runat="server" type="checkbox" name="ch9Apt" />
                                         <label for="ch9Apt">Capacidad de mantenerse actualizado</label>
                                       
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                         <input id="ch10Apt" runat="server" type="checkbox" name="ch10Apt" />
                                         <label for="ch10Apt">Afán de superación</label>
                                       
                                    </td>
                                    <td class="auto-style5">
                                         <input id="ch11Apt" runat="server" type="checkbox" name="ch11Apt" />
                                         <label for="ch11Apt">Responsable</label>
                                        
                                    </td>
                                    <td>
                                         <input id="ch12Apt" runat="server" type="checkbox" name="ch12Apt" />
                                         <label for="ch12Apt">Alta ética</label>
                                        
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                          <input id="ch13Apt" runat="server" type="checkbox" name="ch13Apt" />
                                         <label for="ch13Apt">Conducta emprendedora</label>
                                       
                                    </td>
                                    <td class="auto-style5">
                                        <input id="ch14Apt" runat="server" type="checkbox" name="ch14Apt" />
                                        <label for="ch14Apt">Innovador/a</label>
                                       
                                       
                                    </td>
                                    <td>
                                         <input id="ch15Apt" runat="server" type="checkbox" name="ch15Apt" />
                                         <label for="ch15Apt">Autodidacta</label>
                                        
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                         <input id="ch16Apt" runat="server" type="checkbox" name="ch16Apt" />
                                        <label for="ch16Apt">Conciencia de la realidad social</label>
                                       
                                    </td>
                                    <td class="auto-style5">
                                        <input id="ch17Apt" runat="server" type="checkbox" name="ch17Apt" />
                                        <label for="ch17Apt">Interés por la investigación</label>
                                       
                                    </td>
                                    <td>
                                        <input id="ch18Apt" runat="server" type="checkbox" name="ch18Apt" />
                                        <label for="ch18Apt">Trabajar bajo presión</label>
                                        
                                    </td>
                                </tr>
                            </table>
                          </div>
                    </div>     
              </div>

             <div class="FormCursos">
                 <div class="FormGroup">
                       <h1>Cursos</h1>
                       <div class="ContSlider">
                            <h3>Asigne un valor para este criterio</h3>
                            <input id="Range5" type="range" runat="server" min="1" max="100" oninput="document.getElementById('Label5').textContent = this.value;"  />
                            <asp:Label ID="Label5" runat="server" Text="50" ForeColor="#329040"></asp:Label>
                       </div>
                       <div class="checkbox">
                            <div class="checkbox">
                              <table style="width: 93%;">
                                <tr>
                                    <td class="auto-style4">
                                          <input id="ch1Cur" runat="server" type="checkbox" name="ch1Cur" />
                                          <label for="ch1Cur">Internet de las cosas</label>
                                    </td>
                                    <td class="auto-style5">
                                          <input id="ch2Cur" runat="server" type="checkbox" name="ch2Cur" />
                                          <label for="ch2Cur">Sistemas embebidos</label>
                                  
                                    </td>
                                    <td>
                                         <input id="ch3Cur" runat="server" type="checkbox" name="ch3Cur" />
                                         <label for="ch3Cur">ERP</label>
                              
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                         <input id="ch4Cur" runat="server" type="checkbox" name="ch4Cur" />
                                         <label for="ch4Cur">IHC</label>
                              
                                       
                                    </td>
                                    <td class="auto-style5">
                                         <input id="ch5Cur" runat="server" type="checkbox" name="ch5Cur" />
                                         <label for="ch5Cur">SQL Server</label>
                                        
                                    </td>
                                    <td>
                                         <input id="ch6Cur" runat="server" type="checkbox" name="ch6Cur" />
                                         <label for="ch6Cur">Word</label>
                                       
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                        <input id="ch7Cur" runat="server" type="checkbox" name="ch7Cur" />
                                         <label for="ch7Cur">Excel</label>
                                        
                                    </td>
                                    <td class="auto-style5">
                                         <input id="ch8Cur" runat="server" type="checkbox" name="ch8Cur" />
                                         <label for="ch8Cur">Photoshop</label>
                                        
                                    </td>
                                    <td>
                                         <input id="ch9Cur" runat="server" type="checkbox" name="ch9Cur" />
                                         <label for="ch9Cur">Google Docs</label>
                                       
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                         <input id="ch10Cur" runat="server" type="checkbox" name="ch10Cur" />
                                         <label for="ch10Cur">Windows 10</label>
                                       
                                    </td>
                                    <td class="auto-style5">
                                         <input id="ch11Cur" runat="server" type="checkbox" name="ch11Cur" />
                                         <label for="ch11Cur">Microsoft Azure</label>
                                        
                                    </td>
                                    <td>
                                         <input id="ch12Cur" runat="server" type="checkbox" name="ch12Cur" />
                                         <label for="ch12Cur">MS Dynamics</label>
                                        
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                          <input id="ch13Cur" runat="server" type="checkbox" name="ch13Cur" />
                                         <label for="ch13Cur">Virtualización</label>
                                       
                                    </td>
                                    <td class="auto-style5">
                                        <input id="ch14Cur" runat="server" type="checkbox" name="ch14Cur" />
                                        <label for="ch14Cur">Windows Server</label>
                                       
                                       
                                    </td>
                                    <td>
                                         <input id="ch15Cur" runat="server" type="checkbox" name="ch15Cur" />
                                         <label for="ch15Cur">Exchange Server</label>
                                        
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style4">
                                         <input id="ch16Cur" runat="server" type="checkbox" name="ch16Cur" />
                                        <label for="ch16Cur">Cloud Computing</label>
                                       
                                    </td>
                                    <td class="auto-style5">
                                        <input id="ch17Cur" runat="server" type="checkbox" name="ch17Cur" />
                                        <label for="ch17Cur">AngularJS</label>
                                       
                                    </td>
                                    <td>
                                        <input id="ch18Cur" runat="server" type="checkbox" name="ch18Cur" />
                                        <label for="ch18Cur">Seguridad Informatica</label>
                                        
                                    </td>
                                </tr>
                            </table>
                         </div>
                     </div>
                </div>

            <div class="FormIdiomas">
                 <h1>Conocimiento de idiomas</h1>
                  <div class="ContSlider">
                       <h3>Asigne un valor para este criterio</h3>
                       <input id="Range6" type="range" runat="server" min="1" max="100" oninput="document.getElementById('Label6').textContent = this.value;"  />
                       <asp:Label ID="Label6" runat="server" Text="50" ForeColor="#329040"></asp:Label>
                  </div>
                   <div class="ContSlider">
                        <h3>Dominio del Inglés</h3>
                        <input id="RangoIngles" type="range" runat="server" min="1" max="100" oninput="document.getElementById('lblRIngles').textContent = this.value;"  />
                        <asp:Label ID="lblRIngles" runat="server" Text="50" ForeColor="#329040"></asp:Label>
                    </div>
                    <div class="ContSlider">
                        <h3>Dominio del francés</h3>
                        <input id="RangoFrances" type="range" runat="server" min="1" max="100" oninput="document.getElementById('lblRFrances').textContent = this.value;"  />
                        <asp:Label ID="lblRFrances" runat="server" Text="50" ForeColor="#329040"></asp:Label>
                    </div>
                    <div class="ContSlider">
                        <h3>Dominio del portugues</h3>
                         <input id="RangoPortugues" type="range" runat="server" min="1" max="100" oninput="document.getElementById('lblRPortugues').textContent = this.value;"  />
                        <asp:Label ID="lblRPortugues" runat="server" Text="50" ForeColor="#329040"></asp:Label>
                    </div>
                    <div class="ContSlider">
                        <h3>Dominio del japones</h3>
                         <input id="RangoJapones" type="range" runat="server" min="1" max="100" oninput="document.getElementById('lblRJapones').textContent = this.value;"  />
                        <asp:Label ID="lblRJapones" runat="server" Text="50" ForeColor="#329040"></asp:Label>
                    </div>
                    <div class="ContSlider">
                         <h3>Dominio del chino</h3>
                         <input id="RangoChino" type="range" runat="server" min="1" max="100" oninput="document.getElementById('lblRChino').textContent = this.value;"  />
                        <asp:Label ID="lblRChino" runat="server" Text="50" ForeColor="#329040"></asp:Label>
                    </div>
                  
            </div>
                <asp:Button ID="btnGuardarIdioma" runat="server" Text="Guardar" CssClass="btn_Guardar" OnClick="btnGuardarIdioma_Click"/>
                <asp:Button ID="btnCancelarIdioma" runat="server" Text="Cancelar" CssClass="btn_Cancelar" />
        </div>        
      </div>
    </form>
</body>
</html>
