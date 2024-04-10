# Copilot Api Endpoint

- [Copilot Api Endpoint](#copilot-api-endpoint)
  - [Beta](#beta)
    - [Create Copilot Message Request (beta)](#create-copilot-message-request-beta)
    - [Create Copilot Message Response (beta)](#create-copilot-message-response-beta)
  - [V1 - with auth](#v1---with-auth)
    - [Create Copilot Message Request (V1)](#create-copilot-message-request-v1)
    - [Create Copilot Message Response (V1)](#create-copilot-message-response-v1)

## Beta

### Create Copilot Message Request (beta)

```js
POST '/api/beta/chats/{chatId}/copilot/messages'
```

```json
{
  "text": "Summarize what Maiju talked about in the past 2 days",
  "createdBy": "00000000-0000-0000-0000-000000000000"
}
```

### Create Copilot Message Response (beta)

```json
{
  "copilotText": "In the last 2 days, Maiju talked about...",
  "createdDateTime": "2024-04-10T00:00:00.000Z"
}
```

## V1 - with auth

### Create Copilot Message Request (V1)

```js
POST '/api/v1/chats/{chatId}/copilot/messages'
```

```json
{
  "text": "Summarize what Maiju talked about in the past 2 days",
  "createdBy": "00000000-0000-0000-0000-000000000000"
}
```

### Create Copilot Message Response (V1)

```json
{
  "id": "00000000-0000-0000-0000-000000000000",
  "copilotText": "In the last 2 days, Maiju talked about...",
  "createdBy": "00000000-0000-0000-0000-000000000000",
  "createdDateTime": "2024-04-10T00:00:00.000Z"
}
```
