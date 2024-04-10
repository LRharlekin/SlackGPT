# Api

- [Api](#api)
  - [Chat](#chat)
    - [Create Chat Request](#create-chat-request)
    - [Create Chat Response](#create-chat-response)

## Chat

### Create Chat Request

```js
POST '/api/chats'
```

```json
{
  "createdBy": "00000000-0000-0000-0000-000000000000",
  "secondParty": "00000000-0000-0000-0000-000000000000"
}
```

### Create Chat Response

```json
{
  "id": "00000000-0000-0000-0000-000000000000",
  "createdBy": "00000000-0000-0000-0000-000000000000",
  "secondParty": "00000000-0000-0000-0000-000000000000",
  "createdDateTime": "2024-04-10T00:00:00.000Z"
}
```
