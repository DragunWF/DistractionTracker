# Data Structure

## Data Models

### Distraction

- `DistractionName`
  - **Description:** Indicates the name of the distraction
  - **Data Type:** `String`
- `DistractionCount`
  - **Description:** Indicates the number of times the user got distracted by a particular distraction
  - **Data Type:** `Integer`

### Session

- `Date`
  - **Description:** Indicates the date of when the work session started as a string
  - **Data Type:** `String`
- `DistractionTypes`
  - **Description:** Indicates the number of different distractions that the user got distracted by in a deep work session
  - **Data Type:** `Integer`
- `TotalDistractionCount`
  - **Description:** Indicates the total number of times the user got distracted
  - **Data Type:** `Integer`
- `Distractions`
  - **Description:** Contains a list of distractions that in a deep work session
  - **Data Type:** `List<Distraction>`
