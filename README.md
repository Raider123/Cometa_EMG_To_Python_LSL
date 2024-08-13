# Cometa_EMG_To_Python_LSL
Using the LSL-Integration in C# to transmit data from the Cometa wireless EMG system for subsequent use in a Python environment.

Few hints:

1. Stabilization Period for EMG System

When the "START" button is pressed, the EMG system requires approximately 3 to 4 seconds to stabilize before it begins sending accurate results. During this period, the system calibrates and filters the incoming signals to ensure that the data is reliable for further analysis.
WaveplusDaqExampleForm Features

2. Callback Frequency Adjustment:
    The WaveplusDaqExampleForm allows the user to adjust the frequency of callbacks within a second, which directly affects the collection of EMG samples.
    Users can set the callback frequency from 100ms up to 10ms intervals, providing flexibility in how often data is collected and processed.

3. Battery Display for EMG Sensors:
    The form also includes a feature to display the battery levels of connected EMG sensors.
    Each sensor’s battery status is shown on the UI with a corresponding progress bar, allowing the user to monitor the power levels of the sensors in real-time.


Functionality of Sender.cs

The Sender.cs script is responsible for managing the transmission of EMG data in the system. Below is a detailed explanation of its key functionalities:
1. Integration with WaveplusDaqExampleForm

    The script integrates directly with the WaveplusDaqExampleForm, a form that manages EMG data acquisition.
    Upon initialization, Sender.cs creates an instance of WaveplusDaqExampleForm, making the form visible to the user and preparing it for data capture.

2. LSL (Lab Streaming Layer) Stream Setup

    Sender.cs sets up a Lab Streaming Layer (LSL) stream to transmit EMG data.
    It creates a StreamInfo object to define the stream's metadata (e.g., name, type, channel count, sample rate).
    A StreamOutlet is then created, which acts as the output channel for sending EMG data to the LSL network.

3. User Interface Management

    The script initializes a simple user interface consisting of a "Start/Stop" button and a text box for displaying output.
    The "Start" button begins the EMG data capture process when clicked, changing its label to "Stop" while the data stream is active.

4. Data Streaming and Callback Handling

    When the "Start" button is clicked, the script starts a loop in a separate task that continuously captures and transmits EMG data until the process is manually stopped.
    EMG data is retrieved from the WaveplusDaqExampleForm and sent through the LSL stream at regular intervals.
    The script handles the real-time data transmission, ensuring that EMG samples are pushed to the LSL stream consistently.

5. Data Display

    As EMG data is sent, it is also displayed in the text box within the form. This allows users to monitor the data being transmitted in real-time.
    The data is presented in a readable format, showing the values of the EMG samples in the text box.

6. Graceful Shutdown

    Sender.cs includes functionality to handle the application's shutdown process.
    When the form is closing, it cancels any ongoing data transmission to ensure that the application shuts down cleanly.

For demonstration purposes you can use the added receiver_lsl_test.py script can be used.

