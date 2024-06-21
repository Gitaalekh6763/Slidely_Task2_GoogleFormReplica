
# Google Forms Replica
A desktop app in Visual Basic .NET for creating and viewing forms.
The backend server for the Google Forms Replica task, built with Express and TypeScript. The server uses a JSON file as a database to store form submissions.
## Setup

1. Clone the repository:
   ```bash
   git clone https://github.com/Gitaalekh6763/Slidely_Task2_GoogleFormReplica
   cd GoogleFormsBackend
   ```
2. ```bash
    npm install
    ```
3. ```bash
      npm run dev
      ```
4. open the below file in visual Studio (not Visual Studio Code)
    ```bash
        GoogleFormsFrontend/GoogleFormReplica.sln
    ```

## Compulsory Endpoints

- **GET /ping**: Always returns `{ success: true }`
- **POST /submit**: Accepts form data and saves it to the database
  - Request body: `{ "name": "string", "email": "string", "phone": "string", "github_link": "string", "stopwatch_time": "string" }`
- **GET /read**: Retrieves a form submission by index
  - Query parameter: `index` (0-based)

## Compulsory Features
    1. Create Submissions
    2. View Submissions
    3. Keyboard Shortcuts

## Additional Endpoints
- **Get /search : Return from data matching to email
- **Delete /delete : Delete the form data
- **Update /update : Update the form data

## Additional Features
    1. Edit
    2. Delete
    3. Search
