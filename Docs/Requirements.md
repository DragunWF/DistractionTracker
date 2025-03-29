# Distraction Tracker App - Requirements Specification

## 1. Overview

The Distraction Tracker is a Windows Forms application designed to help users monitor and analyze distractions during deep work sessions, with the goal of improving focus and productivity.

## 2. Functional Requirements

### 2.1 Distraction Logging

- [x] The application SHALL provide a text input box for users to enter distractions in real-time
- [x] Users MUST be able to add a new distraction by:
  - [x] Typing the distraction description
  - [x] Clicking an "Add Distraction" button
  - [x] By pressing the ENTER key
  - [x] Clicking the most recently entered distractions to increment its count via a combo box

### 2.2 Distraction List Management

- [x] The application SHALL display a list of distractions that includes:
  - [x] Distraction name
  - [x] Number of times each distraction occurred
- [x] Users MUST be able to:
  - [x] View the complete list of distractions
  - [x] Clear the entire distraction list
  - [x] Delete individual distraction entries

### 2.3 Data Persistence

- [x] The application SHALL use JSON for data storage

### 2.4 Session Management

- [x] Users MUST be able to:
  - [x] Start a new work session
  - [x] See the timestamp of start and end of a work session
  - [x] End the current work session
  - [x] Reset distraction statistics for a new session
  - [x] See a complete history of previous work sessions
    - [x] Be able to view each individual work session in detail

### 2.5 Reporting and Insights

- [x] The application SHALL provide basic reporting features:
  - [x] Total number of deep work sessions
  - [x] Total number of distractions per session
  - [x] Most frequent distraction
  - [x] Least frequent distraction

## 3. Non-Functional Requirements

### 3.1 User Interface

- Clean and minimalist design
- Intuitive controls
- Responsive layout
- Clear typography

### 3.2 Performance

- Quick distraction logging (minimal input delay)
- Fast JSON read/write operations
- Low memory footprint

### 3.3 Reliability

- Robust error handling for file operations

## 4. Technical Specifications

- Platform: Windows Desktop
- Framework: .NET Framework with WinForms
- Programming Language: C#
- Data Storage: JSON file
- Minimum Windows Version: Windows 7 or later

## 5. Future Enhancement Considerations

- Data visualization of distraction patterns
- Integration with productivity tracking
- Customizable distraction categories
- Machine learning-based distraction prediction

## 6. Constraints

- Must work offline
- No external dependencies beyond .NET Framework
- Minimal third-party library usage
