*** Settings ***
Documentation       Hacer un registro llenando todos los campos obligatorios
Library             Selenium2Library

*** Test Cases ***
CP001 Hacer un registro llenando todos los campos obligatorios
    Open Browser    http://localhost:8080/Crud-java-web-oracle-Cesar/     chrome
    Wait Until Element Is Visible   xpath=/html/body/div/div/div/div/form/div[5]/a[1]
    Click Element       xpath=/html/body/div/div/div/div/form/div[5]/a[1]
    Set Screenshot Directory   Pruebas
    Capture Page Screenshot   1.png
    sleep  3s

    Input Text      xpath=/html/body/div/div/div/form/div[2]/input    usuario11
    Capture Page Screenshot   2.png
    Input Text      xpath=/html/body/div/div/div/form/div[3]/input    cxzcxz@gmail.com
    Capture Page Screenshot   3.png
    Input Text      xpath=/html/body/div/div/div/form/div[4]/input    cxzcxzz
    Capture Page Screenshot   4.png
    Input Text      xpath=/html/body/div/div/div/form/div[5]/input    1234+1234
    Capture Page Screenshot   5.png
    Input Text      xpath=/html/body/div/div/div/form/div[6]/input    1234+1234
    Capture Page Screenshot   6.png
    sleep  5s
    Click Element       xpath=/html/body/div/div/div/form/div[7]/input
    Capture Page Screenshot   7.png
    Element Text Should Be    //p[@class='text-danger']    Te registraste con éxito

    sleep  3s
    Title Should Be     JSP Page
    Page Should Contain     Registro
    Capture Page Screenshot   8.png
    sleep  3s
    Close Browser