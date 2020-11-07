*** Settings***

Documentation    Hacer el test solo llenando un campo del formulario
Library          Selenium2Library


*** Test Cases ***

CP010 Hacer el test solo llenando un campo del formulario

    Open Browser    http://localhost:8080/Crud-java-web-oracle-Cesar/     chrome
    Wait Until Element Is Visible   xpath=/html/body/div/div/div/div/form/div[4]/input
    Set Screenshot Directory   Pruebas
    Capture Page Screenshot   Paso1.png
    Input Text      xpath=/html/body/div/div/div/div/form/div[2]/input     usuario11
    Input Text      xpath=/html/body/div/div/div/div/form/div[3]/input    1234+1234
    Capture Page Screenshot   Paso2.png
    sleep  2s
    Click Element       xpath=/html/body/div/div/div/div/form/div[4]/input
    sleep  5s
    Title Should Be     Inicio
    Page Should Contain     Test de hipertensión
    Wait Until Element Is Visible   xpath=/html/body/div/div[1]/div/div[2]/a
    Capture Page Screenshot   Paso3.png
    Click Element       xpath=/html/body/div/div[1]/div/div[2]/a
    Title Should Be     JSP Page
    Capture Page Screenshot   Paso4.png
    Click Element       xpath=/html/body/div/form/div[1]/label[1]/input
    Sleep  2s
    Click Element       xpath=/html/body/div/form/div[1]/label[3]/input
    sleep  2s
    Click Element       xpath=/html/body/div/form/div[1]/label[8]/input
    Capture Page Screenshot   Paso5.png
    Sleep  3s
    Click Element       xpath=/html/body/div/form/div[4]/input
    Capture Page Screenshot   Paso6.png
    Sleep  5s
    Close Browser