from pylsl import StreamInlet, resolve_stream

# Suche nach einem LSL-Stream vom Typ 'EMG'
print("Looking for an EMG stream...")
streams = resolve_stream('type', 'EMG')

# Verbinde dich mit dem ersten gefundenen Stream
inlet = StreamInlet(streams[0])

print("Now receiving data...")
while True:
    # Ein Sample als Array abrufen
    sample, timestamp = inlet.pull_sample()
    print(f"Received EMG values: {sample} at time {timestamp}")
