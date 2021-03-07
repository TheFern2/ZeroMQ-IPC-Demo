# ZeroMQ-IPC-Demo
Interprocess Communication using ZeroMQ nodejs dotnet python

This is a demo showing IPC communication using [zeromq](https://zeromq.org/)

The client is the dotnet core console application, zeromq supports tons of languages.

# Requirements

- python
- node
- dotnet

# How to use this repo

```
git clone git@github.com:TheFern2/ZeroMQ-IPC-Demo.git
cd server-dotnet
dotnet restore
cd ../nodejs-client
yarn
pip install zmq
```

Now all components are ready to be running.

server dotnet:
```
dotnet run
```

> Allow network permissions

nodejs client:

```
yarn start
```

You should see 10 messags sent from nodejs client to dotnet server.

python client:
```
python client.py
```

You should see 10 messags sent from python client to dotnet server.