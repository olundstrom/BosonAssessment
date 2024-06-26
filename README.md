# BosonAssessment - GoFetch

GoFetch is a frontend application developed using Blazor, allowing users to search and browse dog-related YouTube videos. It leverages YouTube's Data API to fetch video details and display them in an intuitive and user-friendly interface.

## Features

- Search Functionality: Users can enter a search query in the provided search bar on both the home and video page to find dog-related videos. The application defaults to searching for "dog" and appends the user's input to enhance search results.
- Video Listing: GoFetch lists videos matching the user's search query, displaying thumbnails, titles, channel names, and channel logos for each video.
- Video Playback: Users can click on a video thumbnail to view the video on a separate page. The video page displays the video itself, along with the title and channel details.
- Navigation: GoFetch allows users to navigate back to the home page from the video page, retaining their original search query.

## Tech Stack

-Blazor: The application is built using Blazor, a framework for building interactive web UIs with .NET.
-.NET: GoFetch utilizes .NET for server-side logic and API integrations.
-YouTube Data API: GoFetch integrates YouTube's Data API to fetch and display dog-related videos.
-Blazored SessionStorage: Used for session storage to retain user search query across pages.

## Getting Started

To run GoFetch locally, follow these steps:

1. Clone the repository from GitHub to your local machine. You can do this using Git by executing the following command in your terminal or command prompt: git clone https://github.com/olundstrom/BosonAssessment.git
2. Generate your own API key from the YouTube Data API. Documentation: https://developers.google.com/youtube/v3/getting-started
3. Edit the "secrets.json" file in the "Secrets" folder, filling in the following line with your api key: "API_KEY" : "your_api_key_here"
4. Open the solution in Visual Studio or your preferred code editor. Navigate to the directory where you cloned the repository and open the solution file (BosonAssessment.sln).
5. Build and run the application. You can do this in Visual Studio by pressing the play button or by pressing Ctrl + F5.
6. Once the application is running, open your web browser and navigate to the URL displayed by Visual Studio. You can now interact with GoFetch, search for dog-related videos, and enjoy watching them!

## Figma Design

You can view the design for this project on Figma.

[View Figma Design](https://www.figma.com/file/MiPkl2X9zqLcSh84nVrEYj/Boson-Assessment-Brainstorm?type=design&t=jnItrrH4gxwj524b-6)