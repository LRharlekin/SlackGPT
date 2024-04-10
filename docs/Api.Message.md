# Api

- [Api](#api)
  - [Message](#message)
    - [Create Message Request](#create-message-request)
    - [Create Message Response](#create-message-response)

## Message

### Create Message Request

```js
POST '/api/chats/{chatId}/messages'
```

```json
{
  "text": "Whassup team?",
  "createdBy": "00000000-0000-0000-0000-000000000000",
  "secondParty": "00000000-0000-0000-0000-000000000000"
}
```

### Create Message Response

```json
{
  "id": "00000000-0000-0000-0000-000000000000",
  "text": "Whassup team?",
  "createdBy": "00000000-0000-0000-0000-000000000000",
  "secondParty": "00000000-0000-0000-0000-000000000000",
  "createdDateTime": "2024-04-10T00:00:00.000Z"
}
```
