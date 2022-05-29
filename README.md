# Desafio programação

### User Manual

- Click at any time on the "MAIN MENU" button to open the homepage
  ![HomePage](/img/mainMenu.png)
- Click at any time on the "UPLOAD CNAB" button to open the CNAB Uploader menu
  ![CnabUploader](/img/CnabUploader.png)
- Click at any time on the "UPLOAD CNAB" button inside the CNAB Uploader to choose the file path where the CNAB file is located. Once you selected the right file the CNAB will automatcly upload itself to the database
  ![CnabUploader](/img/CnabUploaded.png)
- Click at any time on the "TRANSACTIONS LIST" button to see all the transactions that are located in the database
  ![TransactionsList](/img/transactionsList.png)
- Click at any time on the "BALANCE LIST" button to see the balance calculation from all clients located in the database
  ![TransactionsList](/img/balanceList.png)

### Features

- Upload a CNAB file into the sql database;
- Uptated balence values from each client based on the CNAB files that were uploaded into the application;
- Full list sorted by CPF of the entire history of uploaded data;
- A parserer that reads CNAB file and translate it into data;
- Scalable code;
- Unity tests implemented;

### Tecnologies used

- Windows Forms Application
- SQL Server Express
- Unit Tests
- C#

### Future Implementations

- A login page to make sure the only the people who have permission to add CNAB data are on the application;
- Another table batter separate the registers of CNAB's add from the curret balance for an account;
- Implement a more user friendly interface in order to make navegation easier;
- Transform the form application into an WEB API;
