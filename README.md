# Facebook Clone

This project is a minimal clone of [Facebook](https://facebook.com), aiming to replicate some of its core functionalities. It serves as a practical exercise and demonstration of web development technologies and architectural patterns.

## Technologies Used

- **Server Side**: ASP.NET 7, Entity Framework
- **Identity Service**: Duende Identity (Formely known as IdentityServer)
- **Databe Tech**: SQL Server
- **Client Side**: React JS, Next.js, TailwindCSS

## Architecture

The application follows the principles of [Clean Architecture](https://learn.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/common-web-application-architectures#clean-architecture). This ensures separation of concerns, scalability, and maintainability.

## Features

This is the list of features we initially planned on implementing. We've categorize these features as modules.

### Identity Module
- User registration and authentication

### Post Module
- Adding posts
- Commenting on a post
- Reacting to a post (like, love, laugh and different other types of reactions)
- Replying to a post's comment

### Friend Connection Module
- Adding friends
- Making connection friends
- Chatting with friends
- Viewing friends that are online
- etc...

## Getting Started

Provide a brief guide on how to set up the project.

1. Clone the repository:

   ```bash
   git clone https://github.com/ChrisClaude/FacebookClone
   ```

2. Run the backend

   ```bash
   cd FacebookClone
   cd src/FacebookClone.API
   dotnet ef database update
   dotnet run
   ```
   Make sure the connection string in appsettings.json matches your sql server configurations. You might want to change the credentials to your own credentials.

3. Run the Frontend

   ```bash
   cd FacebookClone
   cd src/web-client
   npm install
   npm dev
   ```

## Contributing

If you wish to contribute, please follow our contributing guidelines. All contributions are welcome, from bug reports to feature requests and pull requests.

## License

This project is open-source under the MIT License.
