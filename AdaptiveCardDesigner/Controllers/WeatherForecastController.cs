using Microsoft.AspNetCore.Mvc;

namespace AdaptiveCardDesigner.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("choicesets")]  // Specify a custom route here if you want
        public IActionResult GetChoicesets()
        {
            var cardDetails = new CardDetails
            {
                Id = "1",
                Title = "ChoiceSets Input",
                Description = "Adaptive card with a choiceset component to capture user selections from predefined options."
            };

            return Ok(cardDetails);  // Return data with 200 OK status
        }

        // Example for Number Inputs
        [HttpGet("numberinputs")]
        public IActionResult GetNumberInputs()
        {
            var cardDetails = new CardDetails
            {
                Id = "AC2",
                Title = "Number Inputs",
                Description = "Adaptive card with a number input component to capture user selections from predefined options."
            };

            return Ok(cardDetails);
        }

        // Example for Toggle Inputs
        [HttpGet("toggleinputs")]
        public IActionResult GetToggleInputs()
        {
            var cardDetails = new CardDetails
            {
                Id = "AC3",
                Title = "Toggle Inputs",
                Description = "Adaptive card with an input.toggle component for users to toggle between two states."
            };

            return Ok(cardDetails);
        }

        // Example for Text Inputs
        [HttpGet("textinputs")]
        public IActionResult GetTextInputs()
        {
            var cardDetails = new CardDetails
            {
                Id = "AC4",
                Title = "Text Inputs",
                Description = "Adaptive card featuring an input.text component to allow users to type freeform text."
            };

            return Ok(cardDetails);
        }

        // Example for DateTime
        [HttpGet("datetime")]
        public IActionResult GetDateTime()
        {
            var cardDetails = new CardDetails
            {
                Id = "AC5",
                Title = "Date Time Input",
                Description = "An adaptive card component for capturing user-selected date and time via a calendar and time picker."
            };

            return Ok(cardDetails);
        }

        // Example for TypeaheadSearch
        [HttpGet("typeaheadsearch")]
        public IActionResult GetTypeaheadSearch()
        {
            var cardDetails = new CardDetails
            {
                Id = "AC6",
                Title = "Dynamic Typeahead",
                Description = "A search input with dynamic suggestions that filter based on user input, improving search efficiency."
            };

            return Ok(cardDetails);
        }

        // Example for DependentDropdown
        [HttpGet("dependentdropdown")]
        public IActionResult GetDependentDropdown()
        {
            var cardDetails = new CardDetails
            {
                Id = "AC7",
                Title = "Dependent Dropdown",
                Description = "A form with dropdown menus where subsequent options depend on prior user selections."
            };

            return Ok(cardDetails);
        }

        // Example for Conditionally Enabled Button
        [HttpGet("conditionallyenabledbutton")]
        public IActionResult GetConditionallyEnabledButton()
        {
            var cardDetails = new CardDetails
            {
                Id = "AC8",
                Title = "Conditionally Enabled Action Button",
                Description = "A button that becomes active only when specific conditions are met, guiding user actions."
            };

            return Ok(cardDetails);
        }

        // Example for Expanded Multiselect
        [HttpGet("expandedmultiselect")]
        public IActionResult GetExpandedMultiselect()
        {
            var cardDetails = new CardDetails
            {
                Id = "AC9",
                Title = "Expanded Multiselects Choicesets",
                Description = "A multiselect component allowing users to choose multiple options from an expanded list for better input flexibility."
            };

            return Ok(cardDetails);
        }

        // Example for Rating Input
        [HttpGet("ratinginput")]
        public IActionResult GetRatingInput()
        {
            var cardDetails = new CardDetails
            {
                Id = "AC10",
                Title = "Rating Input",
                Description = "A component for users to provide feedback by selecting a rating, typically using stars or numeric values."
            };

            return Ok(cardDetails);
        }

        // Example for At Mention
        [HttpGet("atmention")]
        public IActionResult GetAtMention()
        {
            var cardDetails = new CardDetails
            {
                Id = "AC11",
                Title = "At Mention",
                Description = "Allows users to mention other individuals within the adaptive card by selecting from a list or typing their names."
            };

            return Ok(cardDetails);
        }

        // Example for FactSet
        [HttpGet("factset")]
        public IActionResult GetFactSet()
        {
            var cardDetails = new CardDetails
            {
                Id = "AC12",
                Title = "Fact set",
                Description = "A component used to display multiple pieces of related data in a structured card format, ideal for presenting facts or key details."
            };

            return Ok(cardDetails);
        }

        // Example for Container Styles
        [HttpGet("containerstyles")]
        public IActionResult GetContainerStyles()
        {
            var cardDetails = new CardDetails
            {
                Id = "AC13",
                Title = "Container styles",
                Description = "Defines the visual appearance of adaptive card containers, enabling the customization of background colors, borders, and padding."
            };

            return Ok(cardDetails);
        }

        // Example for Layout Flow
        [HttpGet("layoutflow")]
        public IActionResult GetLayoutFlow()
        {
            var cardDetails = new CardDetails
            {
                Id = "AC14",
                Title = "Flow Layout",
                Description = "A layout component that arranges child elements in a flowing, flexible manner, adapting to screen size and content."
            };

            return Ok(cardDetails);
        }

        // Example for Layout Grid Card
        [HttpGet("layoutgridcard")]
        public IActionResult GetLayoutGridCard()
        {
            var cardDetails = new CardDetails
            {
                Id = "AC15",
                Title = "Grid Layout Card",
                Description = "A layout card that arranges content into rows and columns, making it ideal for complex, structured content presentation."
            };

            return Ok(cardDetails);
        }

        // Example for Layout Grid Column
        [HttpGet("layoutgridcolumn")]
        public IActionResult GetLayoutGridColumn()
        {
            var cardDetails = new CardDetails
            {
                Id = "AC16",
                Title = "Grid Layout Column",
                Description = "A layout element used within a grid to define columns for content alignment and organization in an adaptive card."
            };

            return Ok(cardDetails);
        }

        // Example for Image Fit
        [HttpGet("imagefit")]
        public IActionResult GetImageFit()
        {
            var cardDetails = new CardDetails
            {
                Id = "AC17",
                Title = "Image Fit and fill",
                Description = "Defines how images are displayed within a container, including scaling and cropping options for responsive design."
            };

            return Ok(cardDetails);
        }

        // Example for Carousel Page
        [HttpGet("carouselpage")]
        public IActionResult GetCarouselPage()
        {
            var cardDetails = new CardDetails
            {
                Id = "AC18",
                Title = "Carousel Page",
                Description = "A component for creating a swipeable or navigable set of images or cards, ideal for showcasing multiple pieces of content in a single space."
            };

            return Ok(cardDetails);
        }

        // Example for Carousel Bleed
        [HttpGet("carouselbleed")]
        public IActionResult GetCarouselBleed()
        {
            var cardDetails = new CardDetails
            {
                Id = "AC19",
                Title = "Carousel Bleed",
                Description = "A component that extends the edges of a carousel item beyond the containers normal boundaries for a more dynamic, immersive effect."
            };

            return Ok(cardDetails);
        }

        // Line Chart Visualization
        [HttpGet("linecharts")]
        public IActionResult GetLineCharts()
        {
            var cardDetails = new CardDetails
            {
                Id = "AC20",
                Title = "Line Chart Visualization",
                Description = "A component for displaying data trends over time with a line chart, ideal for representing continuous data."
            };

            return Ok(cardDetails);
        }

        // Code Block Display
        [HttpGet("codeblocks")]
        public IActionResult GetCodeBlocks()
        {
            var cardDetails = new CardDetails
            {
                Id = "AC21",
                Title = "Code Block Display",
                Description = "A component for displaying formatted code within a card, supporting syntax highlighting and inline formatting."
            };

            return Ok(cardDetails);
        }

        // Slider Input
        [HttpGet("sliderinput")]
        public IActionResult GetSliderInput()
        {
            var cardDetails = new CardDetails
            {
                Id = "AC22",
                Title = "Slider Input",
                Description = "A component allowing users to select a value from a defined range by sliding a handle along a scale."
            };

            return Ok(cardDetails);
        }

        // Table View
        [HttpGet("tableview")]
        public IActionResult GetTableView()
        {
            var cardDetails = new CardDetails
            {
                Id = "AC23",
                Title = "Table View",
                Description = "A structured component that displays data in a table format, supporting rows and columns for organized information."
            };

            return Ok(cardDetails);
        }

        // Flight Status Update
        [HttpGet("flightupdate")]
        public IActionResult GetFlightUpdate()
        {
            var cardDetails = new CardDetails
            {
                Id = "AC24",
                Title = "Flight Status Update",
                Description = "A component for displaying real-time flight information, such as arrival times, delays, and gate changes."
            };

            return Ok(cardDetails);
        }

        // Progress Bar
        [HttpGet("progressbar")]
        public IActionResult GetProgressBar()
        {
            var cardDetails = new CardDetails
            {
                Id = "AC25",
                Title = "Progress Bar",
                Description = "A visual indicator that shows the completion status of a task or process with a progress bar."
            };

            return Ok(cardDetails);
        }

        // Split Button
        [HttpGet("splitbutton")]
        public IActionResult GetSplitButton()
        {
            var cardDetails = new CardDetails
            {
                Id = "AC26",
                Title = "Split Button",
                Description = "A button component that combines a primary action with a secondary dropdown for additional options."
            };

            return Ok(cardDetails);
        }

        // Progress Ring
        [HttpGet("progressring")]
        public IActionResult GetProgressRing()
        {
            var cardDetails = new CardDetails
            {
                Id = "AC27",
                Title = "Progress Ring",
                Description = "A circular progress indicator that shows the completion status of a task in a ring format."
            };

            return Ok(cardDetails);
        }

        // Badges Card
        [HttpGet("badgescard")]
        public IActionResult GetBadgesCard()
        {
            var cardDetails = new CardDetails
            {
                Id = "AC28",
                Title = "Badges Card",
                Description = "A card component that displays badges or status indicators to represent different categories or notifications."
            };

            return Ok(cardDetails);
        }

        // Show Card
        [HttpGet("showcard")]
        public IActionResult GetShowCard()
        {
            var cardDetails = new CardDetails
            {
                Id = "AC29",
                Title = "Action.Show Card",
                Description = "A component that reveals additional information or options within a card when triggered by user interaction."
            };

            return Ok(cardDetails);
        }

        // Clickable Elements
        [HttpGet("clickableelements")]
        public IActionResult GetClickableElements()
        {
            var cardDetails = new CardDetails
            {
                Id = "AC30",
                Title = "Clickable Elements",
                Description = "Elements within the adaptive card that users can interact with, triggering actions or events."
            };

            return Ok(cardDetails);
        }

        // Rich Text
        [HttpGet("richtext")]
        public IActionResult GetRichText()
        {
            var cardDetails = new CardDetails
            {
                Id = "AC31",
                Title = "Rich Text",
                Description = "A component for displaying formatted text with support for bold, italics, links, and other rich text features."
            };

            return Ok(cardDetails);
        }

        // Compound Button
        [HttpGet("compoundbutton")]
        public IActionResult GetCompoundButton()
        {
            var cardDetails = new CardDetails
            {
                Id = "AC32",
                Title = "Compound Button",
                Description = "A button that combines multiple actions into one, such as a primary action with a secondary menu or option."
            };

            return Ok(cardDetails);
        }

        // Themed URL
        [HttpGet("themedurl")]
        public IActionResult GetThemedUrl()
        {
            var cardDetails = new CardDetails
            {
                Id = "AC33",
                Title = "Themed URL",
                Description = "A clickable URL component that can be styled with different themes for better visual integration."
            };

            return Ok(cardDetails);
        }

        // Icons Customization
        [HttpGet("icons")]
        public IActionResult GetIcons()
        {
            var cardDetails = new CardDetails
            {
                Id = "AC34",
                Title = "Icons Customization",
                Description = "A component that allows users to add and customize icons within an adaptive card for visual enhancement and interactivity."
            };

            return Ok(cardDetails);
        }

        // Image Styles
        [HttpGet("imagestyles")]
        public IActionResult GetImageStyles()
        {
            var cardDetails = new CardDetails
            {
                Id = "AC35",
                Title = "Image Styles",
                Description = "A component for applying different styles and effects to images, such as borders, shadows, and resizing for better visual presentation."
            };

            return Ok(cardDetails);
        }

        // Pie Charts
        [HttpGet("piecharts")]
        public IActionResult GetPieCharts()
        {
            var cardDetails = new CardDetails
            {
                Id = "AC36",
                Title = "Pie Charts Adaptive Card",
                Description = "An adaptive card component designed to display data visually through pie charts, allowing for easy representation of proportional values and insights."
            };

            return Ok(cardDetails);
        }

        // Gauge Charts
        [HttpGet("gaugecharts")]
        public IActionResult GetGaugeCharts()
        {
            var cardDetails = new CardDetails
            {
                Id = "AC37",
                Title = "Gauge Charts Adaptive Card",
                Description = "An adaptive card component for presenting gauge charts, perfect for showing progress or performance metrics in a visual, easy-to-read format."
            };

            return Ok(cardDetails);
        }

        // Templatized Card
        [HttpGet("templatizedcard")]
        public IActionResult GetTemplatizedCard()
        {
            var cardDetails = new CardDetails
            {
                Id = "AC38",
                Title = "Templatized Card with Custom Icons",
                Description = "A customizable adaptive card component that supports adding and modifying icons, enhancing the visual appeal and interactivity of templated cards."
            };

            return Ok(cardDetails);
        }

        // Fallback Image Styling
        [HttpGet("requiresfallback")]
        public IActionResult GetRequiresFallback()
        {
            var cardDetails = new CardDetails
            {
                Id = "AC39",
                Title = "Fallback Image Styling",
                Description = "A component for adaptive cards that applies fallback styling options to images, such as borders, shadows, and resizing, ensuring consistent presentation even if fallback styles are needed."
            };

            return Ok(cardDetails);
        }
    }
}
