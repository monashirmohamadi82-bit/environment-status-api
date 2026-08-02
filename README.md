# environment-status-api


## Title: Build an Environment-Aware Status API

### Description
In ASP.NET Core, the request pipeline can change based on the environment (Development, Production, etc.). In this task, you will create a configuration endpoint that returns different data depending on the active environment, utilizing the C# conditional statements you've learned.

### Requirements
- [ ] **Controller Setup:** Create a new controller called `SystemController`.
- [ ] **Dependency Injection:** Inject `IWebHostEnvironment` into the constructor of your controller so you can read the current environment state.
- [ ] **Create the Endpoint:** Add an `[HttpGet("status")]` endpoint.
- [ ] **Conditional Logic:** Use an `if/else` statement inside the endpoint:
  - If the environment is **Development** (`env.IsDevelopment()`), return a detailed string: `"Status: Running, Environment: Development, Debug Mode: ON"`.
  - If the environment is **Production** (or anything else), return a secure, generic message: `"Status: API is running."`
- [ ] **Testing:** Change your environment variable in `launchSettings.json` from "Development" to "Production" and test the endpoint to ensure the response changes.

### Submission
Push your code to a new branch named `task-environments`. In your Pull Request description, explain exactly which file you modified to change the environment to test your code.

**Labels:** `web-api`, `environments`, `pipeline`
