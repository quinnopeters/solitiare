using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CardCollection : MonoBehaviour
{

	private String _label;
	private Queue<Card> _cards;

	public CardCollection(String label)
	{
		this._cards = new Queue<Card>();
		this._label = label;
	}

	public void addCard(Card card)
	{
		_cards.Enqueue(card);
	}

	public void removeCard()
	{
		_cards.Dequeue();
	}

	public Card GetCard(int i)
	{
		return _cards.Peek();
	}
}
