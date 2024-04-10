# Api

- [Api](#api)
  - [Group](#group)
    - [Create Group Request](#create-group-request)
    - [Create Group Response](#create-group-response)

## Group

### Create Group Request

```js
POST '/api/groups'
```

```json
{
  "name": "My Group",
  "createdBy": "00000000-0000-0000-0000-000000000000",
  "secondParty": "00000000-0000-0000-0000-000000000000"
}
```

### Create Group Response

```json
{
  "id": "00000000-0000-0000-0000-000000000000",
  "name": "My Group",
  "createdBy": "00000000-0000-0000-0000-000000000000",
  "secondParty": "00000000-0000-0000-0000-000000000000",
  "createdDateTime": "2024-04-10T00:00:00.000Z"
}
```
