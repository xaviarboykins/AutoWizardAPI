# AutoWizardAPI Documentation

## Introduction

Welcome to the documentation for the AutoWizardAPI, an open-source API that provides car diagnostic services. This API allows developers to retrieve Diagnostic Trouble Codes (DTC) and access related information. With AutoWizardAPI, you can incorporate car diagnostic capabilities into your applications without the need for an API key.

## Purpose

The purpose of AutoWizardAPI is to provide developers with a flexible and transparent solution for accessing car diagnostic information. The API is designed to be easily accessible and customizable, enabling developers to build intelligent diagnostic applications, vehicle monitoring systems, or any other software solution that requires car diagnostic capabilities.

## Key Features

- Retrieve Diagnostic Trouble Codes (DTC) for vehicles.
- Access detailed descriptions and possible causes for specific DTC codes.
- Get recommended solutions for addressing specific DTC codes.
- Perform searches for DTC codes based on various criteria.
- Easy integration with your applications and services.

## Getting Started

To get started with the AutoWizardAPI, follow these steps:

1. Clone or download the API source code from the official repository on GitHub. The source code is openly available, allowing you to explore, modify, and adapt the API to suit your specific needs. The repository also contains documentation, examples, and resources to help you understand and utilize the API effectively.

2. Install the required NuGet packages, including `Microsoft.AspNetCore.Mvc`, `Microsoft.EntityFrameworkCore`, `Microsoft.EntityFrameworkCore.SqlServer`, `Swashbuckle.AspNetCore`, and `Newtonsoft.Json`.

3. Make sure you have the necessary software installed, including the Microsoft .NET SDK, Visual Studio (or Visual Studio Code), and SQL Server if you plan to use it as the database.

4. Set up your development environment and configure the API according to your requirements.

5. Explore the API endpoints, request/response formats, and error handling to understand how to interact with the AutoWizardAPI effectively.

### Version History

- **Version: 1.0.0 (Initial Release)**

  - Initial release of the AutoWizardAPI.
  - Basic implementation of the Car Diagnostic Trouble Codes (DTC) API.
  - Ability to retrieve all DTC codes and search for specific codes by providing the code as a parameter.
  - Proper error handling and HTTP status code responses.
  - Support for JSON serialization and deserialization.
  - Integration with an MSSQL database for storing DTC code information.
  - Implementation of error handling for cases where invalid or nonexistent DTC codes are requested.
  - API endpoints for interacting with the DTC code data.

Future versions of the AutoWizardAPI will focus on enhancing the existing functionality and introducing new features. These updates may include:

- Expansion of the DTC code database to cover more car makes and models.
- Addition of more detailed descriptions and solutions for each DTC code.
- Integration with external APIs to provide real-time data and information related to DTC codes.
- Advanced search capabilities, allowing users to search for codes based on specific criteria.
- Authentication and authorization mechanisms to secure the API endpoints.
- Implementation of rate limiting and throttling to manage API usage and prevent abuse.
- Support for internationalization and localization to cater to a global user base.
- Improved documentation and developer resources, including detailed API reference documentation and sample code snippets.

Stay tuned for future releases of the AutoWizardAPI as we continue to enhance and improve the functionality of our car diagnostic services. We value your feedback and suggestions as we strive to make the AutoWizardAPI a valuable tool for developers in the automotive industry.

## Feedback and Contributions

AutoWizardAPI is a solo-driven project, and your feedback, suggestions, and contributions are valuable. If you encounter any issues, have ideas for improvements, or would like to contribute to the development of

 the API, please feel free to reach out to xaviarboykins@outlook.com.

Let's leverage the power of car diagnostics together with the open-source AutoWizardAPI!

## AutoWizardAPI Endpoints

The DTCCode API allows you to retrieve Diagnostic Trouble Codes (DTC) for vehicles. You can get a list of all available DTC codes or retrieve details for a specific DTC code.

### Get All DTC Codes

Retrieve a list of all available DTC codes.

**Request**

- Method: `GET`
- URL: `/api/DTCCode`

**Response**

- Status Code: `200 OK`
- Body:
  ```json
  [
    {
      "code": "P0010",
      "description": "A Camshaft Position Actuator Circuit (Bank 1)",
      "possibleCauses": "1. Faulty camshaft position actuator\n2. Camshaft position actuator harness is open or shorted\n3. Camshaft position actuator circuit poor electrical connection\n4. Faulty Engine Control Module (ECM)",
      "solutions": "1. Replace the camshaft position actuator\n2. Repair or replace the camshaft position actuator harness\n3. Check the electrical connections for any loose or damaged wires\n4. Replace the Engine Control Module (ECM)"
    },
    {
      "code": "P0300",
      "description": "Random/Multiple Cylinder Misfire Detected",
      "possibleCauses": "1. Faulty spark plugs or ignition coils\n2. Fuel delivery issues\n3. Engine mechanical problems\n4. Faulty sensors (e.g., crankshaft position sensor, camshaft position sensor)",
      "solutions": "1. Inspect and replace spark plugs or ignition coils as necessary\n2. Check fuel pressure and fuel injectors\n3. Perform a compression test and inspect engine components\n4. Test and replace faulty sensors"
    },
    ...
  ]
  ```

### Get DTC Code by Code

Retrieve details for a specific DTC code.

**Request**

- Method: `GET`
- URL: `/api/DTCCode/{code}`

  - Replace `{code}` with the actual DTC code you want to retrieve, e.g., `/api/DTCCode/P0010`

**Response**

- Status Code: `200 OK`
- Body:
  ```json
  {
    "code": "P0010",
    "description": "A Camshaft Position Actuator Circuit (Bank 1)",
    "possibleCauses": "1. Faulty camshaft position actuator\n2. Camshaft position actuator harness is open or shorted\n3. Camshaft position actuator circuit poor electrical connection\n4. Faulty Engine Control Module (ECM)",
    "solutions": "1. Replace the camshaft position actuator\n2. Repair or replace the camshaft position actuator harness\n3. Check the electrical connections for any loose or damaged wires\n4. Replace the Engine Control Module (ECM)"
  }
  ```

**Possible HTTP Status Codes**

- `200 OK`: The request was successful, and the response body contains the requested DTC code information.
- `404 Not Found`: The requested DTC code does not exist or could not be found.
- `500 Internal Server Error`: An unexpected error occurred while processing the request. The response body may contain additional error details.
