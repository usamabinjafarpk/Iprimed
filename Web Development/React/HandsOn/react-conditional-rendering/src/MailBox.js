import React from 'react'

export default function MailBox(props) {
    const unReadMsg=props.unReadMsg
  return (
    <div>
        Hello
        {unReadMsg>0 && <h1>You have {unReadMsg} unread messages</h1>}
    </div>
  )
}
